using System;

public class Stopwatch {
    private DateTime _startTime;
    private DateTime _stopTime;
    private bool _running;

    public void Start() {
        _startTime = DateTime.Now;
        _running = true;
    }

    public void Stop() {
        _stopTime = DateTime.Now;
        _running = false;
    }

    public int ElapsedMilliseconds {
        get {
            if (_running) {
                return (int)(DateTime.Now - _startTime).TotalMilliseconds;
            } else {
                return (int)(_stopTime - _startTime).TotalMilliseconds;
            }
        }
    }
}