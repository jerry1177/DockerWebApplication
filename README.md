# DockerWebApplication

# Getting started
Make sure to have the prerequisits listed on the presentation. Clone this application. The application will be listening on ports 3000-3003. Make a network called my-network with docker. Open a command prompt and type:

docker network create -d bridge my-network

Now that the network is created, open up the solution with visual studio 2019. You should see four projects, docker-compose, DockerWebServer, WebService1, and WebService2. Make sure you have docker-compose set as the starting project(should already be that). Once this is done, start the debugger, and the website should pop up. click on the test link, and fill out the form. If you fill it out properly, you will be directed to a json page, if not, then you will be prompted to fill it out correctly.
