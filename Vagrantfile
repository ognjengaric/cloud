Vagrant.configure("2") do |config|
  config.vm.box = "hashicorp/bionic64"

  config.vm.network "forwarded_port", guest: 8080, host: 8080

  config.vm.provision "file", source: "cloud-app", destination: "cloud-app"
  config.vm.provision "file", source: "docker-compose.yml", destination: "docker-compose.yml"  

  config.vm.provision :shell, path: "file.sh"
end
