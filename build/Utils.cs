using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;

namespace _build
{
    public static class Utils
    {
        //  example: CreateTarGZ(@"c:\temp\gzip-test.tar.gz", @"c:\data");
        public static async Task CreateTarGz(string sourceDirectory, string tgzFilename)
        {
            var dir = new DirectoryInfo(sourceDirectory);

            await using var fS = File.OpenWrite(tgzFilename);
            await using var gzS = new GZipOutputStream(fS);
            using var tarArchive = TarArchive.CreateOutputTarArchive(gzS);

            AddDirectoryFilesRecursivelyToTar(dir, tarArchive, dir.Name);
        }

        private static void AddDirectoryFilesRecursivelyToTar(DirectoryInfo dir, TarArchive tarArchive, string currentFolderPath)
        {
            // Write each file to the tar.
            var files = dir.GetFiles();
            foreach (var f in files)
            {
                var tarEntry = TarEntry.CreateEntryFromFile(f.FullName);
                tarEntry.Name = Path.Combine(currentFolderPath, f.Name);
                tarArchive.WriteEntry(tarEntry, true);
            }

            var childDirs = dir.GetDirectories();
            foreach (var d in childDirs)
            {
                AddDirectoryFilesRecursivelyToTar(d, tarArchive, Path.Combine(currentFolderPath, d.Name));
            }
        }
    }
}