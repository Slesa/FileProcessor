## Monitor and get real-time statuses using Akka.Net and SignalR

Using the actor model we can create powerful concurrent scalable & distributed applications with Akka.Net.  

 
Are you tired of having to put locks on your shared objects and having to manage your threads.
Do you want to be able to scale your application up by adding actors and even scale out the cluster by just bringing up another service?  
Want to make your application real-time by using a message bus?
Then hopefully this will show you how to create powerful concurrent & distributed applications using Akka.Net and SignalR.
 

To get the solution running follow these step.

1. Install the database - Run the database script Database\BuildAllDatabaseThings.sql.
   	This will setup 2 tables and 2 stored procedues.
   
	**Tables**  
	
		dbo.Location - Contains a location (this is just an example and could be anything from a state or a region)
		dbo.FileSetting - Contains the settings about what folder should be monitored.  
		
	**Store Procedues**
	
		dbo.spLocationsWithFileSettings_Get - Gets all the Location and FileSettings.
		dbo.spLongRunningProcess_ProcessAllThingsMagically - Is used to fake like there is a long running process 
									which raises messages for status update.

2. Create a location - Run the database script Database\CreateDummyRecord.sql.
	This will create a location and file setting for the actor system to use.
	The setting default to c:\common\<LocationName>.  
	When the Processor project runs and picks up the location it will create the folder.

3. Build the solution and launch the following applications.
 

## Framework
* DotNetCore 2.1
* SignalR 
* NetStandard 2.0
* Akka.Net 1.3.10
* Akka.Cluster 1.3.10
* Akka.Cluster.Tools 1.3.10
* FileHelpers 3.3.0
* Knockout 3.3.0

## Projects 

### Lighthouse 
It is a service-discovery service called a seed node. To maintain fault tolerance you should always run two instances which allows other members to join when needed. 


### Processor
      EastCoast
      WestCoast

### Worker
The worker is a cluster member ready for the manager to task work off to.
Demonstrates clean exit when itself is removed from the cluster.
The worker will get a set of records and then process those records.
Report back what the status of the work back to the Tasker.

      EastCoast
      WestCoast

### WebMonitor

### WindowsMonitor
Shows the state of the cluster from its point of view.  Allows you to tell a member of the clister to leave or be considered down. 

### SharedLibrary
Contains the messages, paths and actors that are shared between the above projects.




## Common Akka Links to help you along with your Akka adventure!
Main Site: http://getakka.net/

Documentation: http://getakka.net/docs/

The Code (includes basic examples): https://github.com/akkadotnet/getakka.net

Need to ask a question: https://gitter.im/akkadotnet/akka.net

Where do you begin: https://github.com/petabridge/akka-bootcamp

Where do you begin Part2: https://github.com/petabridge/akkadotnet-code-samples

Webcrawler: https://github.com/petabridge/akkadotnet-code-samples/tree/master/Cluster.WebCrawler

Persistent Actors: https://petabridge.com/blog/intro-to-persistent-actors/



