using FuncionariosEmpresa.Contracts;
using NLog;

namespace FuncionariosEmpresa.LoggerService;

public class LoggerManager : ILoggerManager
{
    private static ILogger logger = LogManager.GetCurrentClassLogger();

    public LoggerManager() { }

    public void LogAdvertencia(string messagem) => logger.Warn(messagem);

    public void LogDepuracao(string messagem) => logger.Debug(messagem);

    public void LogErro(string messagem) => logger.Error(messagem);

    public void LogInformativo(string messagem) => logger.Info(messagem);
}
