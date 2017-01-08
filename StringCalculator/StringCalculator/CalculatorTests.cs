using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using StringCalculator;


public class CalculatorTests
{
    public Calculator Calculator = new Calculator();

    [Test]
    public void EmptyInput_ReturnsZero()
    {
        int result = Calculator.Add("");
        result.Should().Be(0);
    }

    [Test]
    public void OneNumberInput_ReturnsOne()
    {
        int result = Calculator.Add("1");
        result.Should().Be(1);
    }

    [Test]
    public void TwoNumbersInput_ReturnThree()
    {
        int result = Calculator.Add("1,2");
        result.Should().Be(3);
    }

    [Test]
    public void ThreeNumbers_WithNewLineDelimiter_ReturnSix()
    {
        int result = Calculator.Add("1\n2,3");
        result.Should().Be(6);
    }

    [Test]
    public void TwoNumbers_WithDifferentDelimiters_ReturnThree()
    {
        int result = Calculator.Add("//;\n1;2");
        result.Should().Be(3);
    }
}