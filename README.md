# DockerWebApplication

# Getting started
Make sure to have the prerequisits listed on the presentation. Clone this application. The application will be listening on ports 3000-3003. Make a network called my-network with docker. Open a command prompt and type:

docker network create -d bridge my-network

Now that the network my-network (make sure this is the name) is created, open up the solution with visual studio 2019. You should see four projects, docker-compose, DockerWebServer, WebService1, and WebService2. Make sure you have docker-compose set as the starting project(should already be that). Once this is done, start the debugger, and the website should pop up. click on the test link, and fill out the form. If you fill it out properly, you will be directed to a json page, if not, then you will be prompted to fill it out correctly.

# Check out Swagger documentation
I added Swagger documentation to the service1 project. If you want to see the actuall documentation that is generated go to 

http://localhost:3002/swagger

This will take you to the documentation that was created for the project. If you look at the code, you will notice that Swagger is using the attributes we put on the end point functions, and model classes to generate the document. This makes our API projects self documenting!

# Notes
When you stop debugging, this does not stop the docker container. If you run the project individually without docker-compose, and then try to run docker-compose project, you will get a 'process already listening on that port error,' and you need to stop the container through docker desktop.