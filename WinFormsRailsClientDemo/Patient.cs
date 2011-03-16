using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailsClient;

public class Patient : RESTfulResource
{
    public string name { get; set; }
    public int age { get; set; }
    public bool smoker { get; set; }
}