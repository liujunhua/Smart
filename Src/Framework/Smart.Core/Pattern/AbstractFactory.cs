﻿namespace Smart.Core.Pattern
{
    /// <summary>
    /// 抽象工厂模式
    /// •	一个系统不应当依赖于产品类实例如何被创建、组合和表达的细节，这对于所有形态的工厂模式都是重要的。
    /// •	这个系统有多于一个的产品族，而系统只消费其中某一产品族。 
    /// •	同属于同一个产品族的产品是在一起使用的，这一约束必须在系统的设计中体现出来。 
    /// •	系统提供一个产品类的库，所有的产品以同样的接口出现，从而使客户端不依赖于实现。
    /// </summary>
    public abstract class AbstractFactory
    {
    }
}
