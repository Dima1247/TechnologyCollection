#!/bin/bash
sudo apt-get update -y
sudo apt-get install git docker.io docker-compose -y

sudo mkdir app && cd app
sudo git clone https://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@github.com/Dima1247/TestWebAPI.git .
sudo docker-compose -f docker-compose.yml up