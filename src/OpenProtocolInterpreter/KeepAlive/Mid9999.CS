﻿namespace OpenProtocolInterpreter.KeepAlive
{
    /// <summary>
    /// MID: Keep alive message
    /// Description: 
    ///   The integrator sends a keep alive to the controller. The controller should only mirror and return the 
    ///   received keep alive to the integrator.
    ///   The controller has a communication timeout equal to 15s.This means that if no message has been 
    ///   exchanged between the integrator and the controller for the last 15s, then the controller considers 
    ///   the connection lost and closes it.
    ///   In order to keep the communication alive the integrator must send a keep alive to the controller with a
    ///   time interval lower than 15s.
    ///   Note: An inactivity timeout is suggested to integrator i.e. if no message has been exchanged (sent or 
    ///   received) during the last 10s, send a keep alive.
    ///  
    /// Message sent by: Integrator
    /// Answer: The same message mirrored by the controller.
    /// </summary>
    public class Mid9999 : Mid
    {
        private const int LAST_REVISION = 0;
        public const int MID = 9999;

        public Mid9999() : base(MID, LAST_REVISION) { }
    }
}
