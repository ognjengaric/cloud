#!/usr/bin/env bash

# Docker
curl -fsSL https://get.docker.com -o get-docker.sh
sudo sh get-docker.sh

<<<<<<< HEAD
#test
=======
# Docker Compose
sudo curl -L --fail https://github.com/docker/compose/releases/download/1.27.4/run.sh -o /usr/local/bin/docker-compose
sudo chmod +x /usr/local/bin/docker-compose

docker-compose up --build
>>>>>>> 669bfaea35bbb780c26151cc87cbe5aa400d8d70
