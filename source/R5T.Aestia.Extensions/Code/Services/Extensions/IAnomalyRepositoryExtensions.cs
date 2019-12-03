using System;

using R5T.Sindia;
using R5T.Votadinia;


namespace R5T.Aestia
{
    public static class IAnomalyRepositoryExtensions
    {
        /// <summary>
        /// Create a new anomaly (identity) and set the reported UTC time to the current UTC time.
        /// </summary>
        public static AnomalyIdentity NewSetReportedUTC(this IAnomalyRepository repository, ICurrentUtcDateTimeProvider currentUtcDateTimeProvider)
        {
            var anomalyIdentity = repository.New();

            var nowUTC = currentUtcDateTimeProvider.GetCurrentUtcDateTime();

            repository.SetReportedUTC(anomalyIdentity, nowUTC);

            return anomalyIdentity;
        }
    }
}
