using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;

namespace SD.Portal.Lib
{
    public static class MefHelper
    {
        public static void AddExport<TKey>(this CompositionContainer container, object getExportValue)
        {
            container.AddExport<TKey>(() => getExportValue);
        }
        public static void AddExport<TKey>(this CompositionContainer container, Func<object> getExportValue)
        {
            var batch = new CompositionBatch();
            batch.AddExport<TKey>(getExportValue);
            batch.AddExportedValue(batch);
            container.Compose(batch);
        }
        public static ComposablePart AddExport<TKey>(this CompositionBatch batch, Func<object> getExportValue)
        {
            Type exportType = typeof(TKey);
            string contractName = exportType.ToString();
            const string instanceName = "ExportTypeIdentity";

            var metadata = new Dictionary<string, object>() {{instanceName, contractName}};
            var exportDefinition = new ExportDefinition(contractName, metadata);
            var export = new Export(exportDefinition, getExportValue);

            return batch.AddExport(export);
        }
    }
}