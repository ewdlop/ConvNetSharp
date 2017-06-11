﻿using System;
using ConvNetSharp.Flow.Ops;

namespace ConvNetSharp.Flow.Layers
{
    public class SigmoidLayer<T> : LayerBase<T> where T : struct, IEquatable<T>, IFormattable
    {
        public override void AcceptParent(Op<T> parent)
        {
            this.Op = ConvNetSharp<T>.Sigmoid(parent);
        }
    }
}