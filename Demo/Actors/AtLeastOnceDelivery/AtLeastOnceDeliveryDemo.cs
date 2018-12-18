﻿using System.IO;
using Akka.Actor;
using Akka.Configuration;

namespace Demo.Actors.AtLeastOnceDelivery
{
    public static class AtLeastOnceDeliveryDemo
    {
        public static void Start()
        {
            var systemConfig = ConfigurationFactory.ParseString(File.ReadAllText("akka.hocon"));
            var myConfig = systemConfig.GetConfig("myactorsystem");
            var systemName = myConfig.GetString("actorsystem");

            var persistenceConfig = systemConfig.GetConfig("akka.persistence");
            SystemActors.System = ActorSystem.Create(systemName, persistenceConfig);

            var recipientActor = SystemActors.System.ActorOf(Props.Create(() => new MyRecipientActor()), "receiver");
            var atLeastOnceDeliveryActor = SystemActors.System.ActorOf(Props.Create(() => new MyAtLeastOnceDeliveryActor(recipientActor)), "delivery");
            
        }

    }
}