using CommandLine;

namespace TCInstaller_CLI
{
    public class Options
    {
        [Option(
            'c',"clean",
            Default = false, 
            HelpText = "Clean the target directory",
            Required = false
        )]
        public bool clean { get; set; }
        
        [Option(
            Default = null,
            HelpText = "Where the TF2 installation dir is located",
            Required = false
        )]
        public string tf2dir { get; set; }
        
        [Option(
            Default = null,
            HelpText = "Where TC2 should be installed.",
            Required = false
        )]
        public string tc2dir { get; set; }
    }
}