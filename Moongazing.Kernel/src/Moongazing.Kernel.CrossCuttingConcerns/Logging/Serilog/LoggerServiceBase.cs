﻿using Serilog;

namespace Moongazing.Kernel.CrossCuttingConcerns.Logging.Serilog;

public abstract class LoggerServiceBase
{
    public ILogger Logger { get; set; }

    public LoggerServiceBase()
    {
        Logger = null!;
    }

    public LoggerServiceBase(ILogger logger)
    {
        Logger = logger;
    }

    public void Verbose(string message) => Logger.Verbose(message);

    public void Fatal(string message) => Logger.Fatal(message);

    public void Info(string message) => Logger.Information(message);

    public void Warn(string message) => Logger.Warning(message);

    public void Debug(string message) => Logger.Debug(message);

    public void Error(string message) => Logger.Error(message);
}