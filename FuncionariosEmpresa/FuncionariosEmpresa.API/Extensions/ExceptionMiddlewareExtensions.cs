using Entities.ErrorModel;
using FuncionariosEmpresa.Contracts;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace FuncionariosEmpresa.API.Extensions;

public static class ExceptionMiddlewareExtensions
{
    public static void ConfigureExceptionHandler(this WebApplication app, ILoggerManager logger)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature != null)
                {
                    logger.LogErro($"Algo deu errado: {contextFeature.Error}");

                    await context.Response.WriteAsync(new ErrorDetails()
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "Erro Interno no Servidor"
                    }.ToString());
                }
            });
        });
    }
}
