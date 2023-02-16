﻿namespace Flandre.Framework.Attributes;

/// <summary>
/// 指令别名特性
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class AliasAttribute : Attribute
{
    /// <summary>
    /// 指令别名
    /// </summary>
    public string Alias { get; }

    /// <summary>
    /// 为指令添加别名
    /// </summary>
    /// <param name="alias">指令别名</param>
    public AliasAttribute(string alias)
    {
        Alias = alias;
    }
}