# Simple Dockerized ASP.NET Core Web API project using Redis

You may find built docker image of this repo @ [Docker Hub](https://hub.docker.com/r/ilhancengiz/dotnetcore-webapi-redis/)

Wanna Try ?

##### 1st Option (via building new docker image from repo):

 1. Login to [Docker Playground](http://play-with-docker.com) with a DockerID 
 2. Create a new instance to play with
 3. Clone this repo to instance (`git clone https://github.com/ilhancengiz/dotnetcore-webapi-redis.git`) 
 4. Navigate to project folder (`cd dotnetcore-webapi-redis/`) 
 5. Run `docker-compose up -d` command to start services (give docker a few sec to build images) 
 6. Check instance's 5091 port link with /api/values added. 
 7. Congrats!! You're running a ASP.NET Core Web API project with Redis in Docker Containers on Linux host :)

##### 2nd Option (via already built docker image):

 1. Follow first 4 step in 1st option 
 2. Run `docker-compose -f docker-compose-built-image.yaml up -d` command to create services (give docker a few sec to download images) 
 3. Check instance's 5091 port link with /api/values added. 
 4. Congrats!! You're running a ASP.NET Core Web API project with Redis in Docker Containers on Linux host :)
