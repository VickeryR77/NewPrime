using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeLab.Tests
{
    public class PrimeNumbersTest
    {
        //Could not figure out how to get ArrayLists to work with [Theory]
        //Had to use [Facts] as well as make a new list and pull each test.

        [Fact]
        public void Test1()
        {
            int choice = 1;
            ArrayList myList = new ArrayList();
            PrimeNumbers.CreatePrimeList(myList);
            Assert.Equal(2, PrimeNumbers.GetPrime(myList, choice));

        }
        [Fact]
        public void Test2()
        {
            int choice = 2;
            ArrayList myList = new ArrayList();
            PrimeNumbers.CreatePrimeList(myList);
            Assert.Equal(3, PrimeNumbers.GetPrime(myList, choice));

        }
        [Fact]
        public void Test3()
        {
            int choice = 3;
            ArrayList myList = new ArrayList();
            PrimeNumbers.CreatePrimeList(myList);
            Assert.Equal(5, PrimeNumbers.GetPrime(myList, choice));

        }
        [Fact]
        public void Test4()
        {
            int choice = 4;
            ArrayList myList = new ArrayList();
            PrimeNumbers.CreatePrimeList(myList);
            Assert.Equal(7, PrimeNumbers.GetPrime(myList, choice));

        }
        [Fact]
        public void Test5()
        {
            int choice = 5;
            ArrayList myList = new ArrayList();
            PrimeNumbers.CreatePrimeList(myList);
            Assert.Equal(11, PrimeNumbers.GetPrime(myList, choice));

        }
    }
}
