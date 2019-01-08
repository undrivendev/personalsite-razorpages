FROM nginx 

CMD ls -lah
WORKDIR /src
COPY . /usr/share/nginx/html