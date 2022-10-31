using McMaster.Extensions.CommandLineUtils;
using DotNetTools.Labs;

var app = new CommandLineApplication
{
    Name = "Specify a lab work",
    Description = "",
};

app.HelpOption(inherited: true);
app.Command("run", configCmd =>
{
    configCmd.OnExecute(() =>
    {
        Console.WriteLine("Specify aplication:");
        configCmd.ShowHelp();
        return 1;
    });

    // ./DotNetTool run lab1 -I "dataIn.txt" -O "dataOut.txt"
    configCmd.Command("lab1", setCmd =>
    {
        setCmd.Description = "Laboratory work 1";
        var input = setCmd.Option("-I|--input <INPUT>", "Input file path", CommandOptionType.SingleValue);
        var output = setCmd.Option("-O|--output <OUTPUT>", "Output file path", CommandOptionType.SingleValue);
        input.DefaultValue = $"INPUT1.txt";
        output.DefaultValue = $"OUTPUT.txt";
        setCmd.OnExecute(() =>
        {
            Console.WriteLine($"Set input file path: {input.Value()}");
            Console.WriteLine($"Set output file path: {output.Value()}");
            var app = new Lab1(input.Value(), output.Value());
            app.Run();
        });
    });

    // ./DotNetTool run lab2 -I "dataIn.txt" -O "dataOut.txt"
    configCmd.Command("lab2", setCmd =>
    {
        setCmd.Description = "Laboratory work 2";
        var input = setCmd.Option("-I|--input <INPUT>", "Input file path", CommandOptionType.SingleValue);
        var output = setCmd.Option("-O|--output <OUTPUT>", "Output file path", CommandOptionType.SingleValue);
        input.DefaultValue = $"INPUT2.txt";
        output.DefaultValue = $"OUTPUT.txt";
        setCmd.OnExecute(() =>
        {
            Console.WriteLine($"Set input file path: {input.Value()}");
            Console.WriteLine($"Set output file path: {output.Value()}");
            var app = new Lab2(input.Value(), output.Value());
            app.Run();
        });
    });

    // ./DotNetTool run lab3 -I "dataIn.txt" -O "dataOut.txt"
    configCmd.Command("lab3", setCmd =>
    {
        setCmd.Description = "Laboratory work 3";
        var input = setCmd.Option("-I|--input <INPUT>", "Input file path", CommandOptionType.SingleValue);
        var output = setCmd.Option("-O|--output <OUTPUT>", "Output file path", CommandOptionType.SingleValue);
        input.DefaultValue = $"INPUT3.txt";
        output.DefaultValue = $"OUTPUT.txt";
        setCmd.OnExecute(() =>
        {
            Console.WriteLine($"Set input file path: {input.Value()}");
            Console.WriteLine($"Set output file path: {output.Value()}");
            var app = new Lab3(input.Value(), output.Value());
            app.Run();
        });
    });
});
app.Command("version", configCmd =>
{
    configCmd.Description = "version of program";
    configCmd.OnExecute(() =>
    {
        Console.WriteLine("Aughtor: Illia");
        Console.WriteLine("Version: 2.0.0");
    });
});
app.OnExecute(() =>
{
    Console.WriteLine("Lab Works");
    app.ShowHelp();
    return 1;
});
return app.Execute(args);