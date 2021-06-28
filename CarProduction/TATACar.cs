using System;
using System.Collections.Generic;
using System.Text;

namespace CarProduction
{
    class TATACar
    {

        IEngine _engine;
      
        public void TataCar(IEngine engine)
        {

            this._engine = engine;
        }

        public void Drive()
        {

           _engine.Start();
        }
        public void Halt()
        {
            
            _engine.Stop();
        }

    }
    public interface IEngine
    {
        void Start();
        void Stop();
    }



    public class DiCorEngine : IEngine
    {
      
        public void Start() {  }
        public void Stop() {  }
    }

    public class VeriCorEngine : IEngine
    {
        public void Start() {  }
        public void Stop() {  }

    }

    public class MultiJetEngine : IEngine
    {
        public void Start() {  }
        public void Stop() {  }
    }
    public class RevorTron : IEngine
    {
        public void Start() {  }
        public void Stop() {  }
    }

}
