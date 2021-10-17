# LRC Cache Code Challenge

Have the function LRUCache(strArr) take the array of characters stored in strArr, which will contain characters ranging from A to Z in some arbitrary order, and determine what elements still remain in a virtual cache that can hold up to 5 elements with an LRU cache algorithm implemented. For example: if strArr is ["A", "B", "C", "D", "A", "E", "D", "Z"], then the following steps are taken:<br/>

(1) A does not exist in the cache, so access it and store it in the cache.<br/>
(2) B does not exist in the cache, so access it and store it in the cache as well. So far the cache contains: ["A", "B"].<br/>
(3) Same goes for C, so the cache is now: ["A", "B", "C"].<br/>
(4) Same goes for D, so the cache is now: ["A", "B", "C", "D"].<br/>
(5) Now A is accessed again, but it exists in the cache already so it is brought to the front: ["B", "C", "D", "A"].<br/>
(6) E does not exist in the cache, so access it and store it in the cache: ["B", "C", "D", "A", "E"].<br/>
(7) D is accessed again so it is brought to the front: ["B", "C", "A", "E", "D"].<br/>
(8) Z does not exist in the cache so add it to the front and remove the least recently used element: ["C", "A", "E", "D", "Z"].<br/>

Now the caching steps have been completed and your program should return the order of the cache with the elements joined into a string, separated by a hyphen. Therefore, for the example above your program should return C-A-E-D-Z.<br/>

# Examples
> Input: new string[] {"A", "B", "A", "C", "A", "B"}<br/>
> Output: C-A-B<br/>

> Input: new string[] {"A", "B", "C", "D", "E", "D", "Q", "Z", "C"}<br/>
> Output: E-D-Q-Z-C<br/>

# Code Coverage
Click the link below to view the Code Coverage

<a href="https://htmlpreview.github.io/?https://github.com/toniolatunji/lru-cache/blob/main/LRUCache/LruCache.Tests/Coverage/index.html" target="_blank">Code Coverage</a>
