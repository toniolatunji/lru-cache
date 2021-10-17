using LruCache.Service.Contract;
using LruCache.Service.Implementation;
using NUnit.Framework;
using System.Collections.Generic;

namespace LruCache.Tests
{
    public class LruCacheServiceTest
    {
        [TestCase("AB", ExpectedResult = "A-B")]
        [TestCase("ABC", ExpectedResult = "A-B-C")]
        [TestCase("ABCD", ExpectedResult = "A-B-C-D")]
        [TestCase("ABCDA", ExpectedResult = "B-C-D-A")]
        [TestCase("ABCDAE", ExpectedResult = "B-C-D-A-E")]
        [TestCase("ABCDAED", ExpectedResult = "B-C-A-E-D")]
        [TestCase("ABCDAEDZ", ExpectedResult = "C-A-E-D-Z")]
        public string LruCache_Returns_CorrectCachedItems(string input)
        {
            var stringArray = ConvertStringToArray(input);

            ILruCacheService lruCacheService = new LruCacheService();

            lruCacheService.ReInitializeCache();

            return lruCacheService.LruCache(stringArray);
        }

        private static string[] ConvertStringToArray(string input)
        {
            List<string> list = new();

            foreach (var item in input)
            {
                list.Add($"{item}");
            }

            return list.ToArray();
        }
    }
}