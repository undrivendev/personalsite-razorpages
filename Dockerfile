FROM nginx 

RUN ls -la
WORKDIR /src
COPY . /usr/share/nginx/html