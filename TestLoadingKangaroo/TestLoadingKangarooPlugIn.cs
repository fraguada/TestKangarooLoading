﻿using Rhino.PlugIns;

namespace TestLoadingKangaroo
{
    ///<summary>
    /// <para>Every RhinoCommon .rhp assembly must have one and only one PlugIn-derived
    /// class. DO NOT create instances of this class yourself. It is the
    /// responsibility of Rhino to create an instance of this class.</para>
    /// <para>To complete plug-in information, please also see all PlugInDescription
    /// attributes in AssemblyInfo.cs (you might need to click "Project" ->
    /// "Show All Files" to see it in the "Solution Explorer" window).</para>
    ///</summary>
    public class TestLoadingKangarooPlugIn : Rhino.PlugIns.PlugIn

    {
        public TestLoadingKangarooPlugIn()
        {
            Instance = this;
        }

        ///<summary>Gets the only instance of the TestLoadingKangarooPlugIn plug-in.</summary>
        public static TestLoadingKangarooPlugIn Instance
        {
            get; private set;
        }

        // You can override methods here to change the plug-in behavior on
        // loading and shut down, add options pages to the Rhino _Option command
        // and maintain plug-in wide options in a document.

        protected override LoadReturnCode OnLoad(ref string errorMessage)
        {
            Rhino.RhinoApp.WriteLine("TestLoadingKangarooLoaded");

            Rhino.Runtime.AssemblyResolver.AddSearchFile(@"C:\Program Files\Rhino 6\Plug-ins\Grasshopper\Components\KangarooSolver.dll");

            return base.OnLoad(ref errorMessage);
        }
    }
}