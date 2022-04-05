using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using MirrorSharp.Internal.Roslyn.Internals;

namespace MirrorSharp.Internal.Roslyn43 {
    [Shared]
    [Export(typeof(IWorkspaceAnalyzerOptionsInternals))]
    internal class WorkspaceAnalyzerOptionsInternals : IWorkspaceAnalyzerOptionsInternals {
        public AnalyzerOptions New(AnalyzerOptions options, Solution solution) {
            return new WorkspaceAnalyzerOptions(options, solution, IdeAnalyzerOptions.Default);
        }
    }
}
