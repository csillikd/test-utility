﻿namespace TestAssembly
{
    internal class InternalClass : IInternalInterface
    {
        internal delegate void InternalDelegate();

        private delegate void PrivateDelegate();

        public void Test()
        {
        }

        public class NestedPublicClass
        {
            public void Test()
            {
            }
        }
    }
}
