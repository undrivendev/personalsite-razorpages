
server {
        server_name lucadallavalle.com www.lucadallavalle.com;

        location / {
            proxy_set_header Host $host;
            proxy_set_header X-Real-IP $remote_addr;
            proxy_pass http://localhost:8080;
        }
}