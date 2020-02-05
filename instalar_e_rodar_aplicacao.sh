#!/bin/bash
echo "Instalando e inicializando a aplicacao TesteDBServer"
sudo docker build -f src/WebApi/Dockerfile -t webapi src
sudo docker-compose up -d