﻿using System.Collections.Generic;

namespace Jaeger.SAT.API.Services.Interfaces {
    /// <summary>
    /// Service Verify Result
    /// </summary>
    public interface IVerifyResponse {
        #region propiedades
        /// <summary>
        /// Codigo de estado de la llamada. (CodStatus)
        /// </summary>
        IStatusCode StatusCode { get; }

        /// <summary>
        /// obtener el numero correspondiente al estado de la solicitud de descarga, Estados de la solicitud: Aceptada=1, EnProceso=2, Terminada=3, Error=4, Rechazada=5, Vencida=6 (EstadoSolicitud)
        /// </summary>
        IStatusRequest StatusRequest { get; }

        /// <summary>
        /// Codigos de status de solicitud
        /// </summary>
        ICodeRequest CodeRequest { get; }

        /// <summary>
        /// obtener o establecer numero de CFDIs que conforman la solicitud de descarga consultada.
        /// </summary>
        int NumberCfdis { get; }

        /// <summary>
        /// obtener o establecer (IdsPaquetes) identificadores de los paquetes que componen la solicitud de descarga masiva. Solo se devuelve cuando la solicitud posee un estatus de finalizado.
        /// </summary>
        List<string> PackagesIds { get; }

        /// <summary>
        /// obtener o establecer contenido de la respuesta en formato XML
        /// </summary>
        string XML { get; }
        #endregion

        #region build
        /// <summary>
        /// Codigo de estado de la llamada. (CodStatus)
        /// </summary>
        IVerifyResponse AddStatusCode(IStatusCode statusCode);

        /// <summary>
        /// numero correspondiente al estado de la solicitud de descarga, Estados de la solicitud: Aceptada=1, EnProceso=2, Terminada=3, Error=4, Rechazada=5, Vencida=6 (EstadoSolicitud)
        /// </summary>
        IVerifyResponse AddStatusRequest(IStatusRequest status);

        /// <summary>
        /// Codigos de status de solicitud
        /// </summary>
        IVerifyResponse AddCodeRequest(ICodeRequest codeRequest);

        /// <summary>
        /// numero de CFDIs que conforman la solicitud de descarga consultada.
        /// </summary>
        IVerifyResponse AddNumnberCFDIs(int numberCFDIs);

        /// <summary>
        /// identificadores de los paquetes que componen la solicitud de descarga masiva. Solo se devuelve cuando la solicitud posee un estatus de finalizado.
        /// </summary>
        IVerifyResponse AddPackagesIds(List<string> packages);

        /// <summary>
        /// establecer contenido de la respuesta en formato XML
        /// </summary>
        IVerifyResponse AddXML(string xml);
        #endregion
    }
}
