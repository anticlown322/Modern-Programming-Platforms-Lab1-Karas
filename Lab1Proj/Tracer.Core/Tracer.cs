using System.Diagnostics;

namespace Tracer.Core;

public class Tracer : ITracer
{
    private Stopwatch   _stopwatch;
    private TraceResult _traceResult;
    private string?     _methodName;
    private string?     _className;

    public Tracer()
    {
        _stopwatch = new Stopwatch();
        _traceResult = new TraceResult();
    }
    
    public void StartTrace()
    {
        _stopwatch.Start();
    }

    public void StopTrace()
    {
        _stopwatch.Stop();
    }

    public TraceResult GetTraceResult()
    {
        return _traceResult;
    }
}