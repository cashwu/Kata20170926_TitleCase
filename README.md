# [Title Case](https://www.codewars.com/kata/title-case/csharp)

---

A string is considered to be in title case if each word in the string is either (a) capitalised (that is, only the first letter of the word is in upper case) or (b) considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.

Write a function that will convert a string into title case, given an optional list of exceptions (minor words). The list of minor words will be given as a string with each word separated by a space. Your function should ignore the case of the minor words string -- it should behave in the same way even if the case of the minor word string is changed.

### Arguments (Haskell)

- First argument: space-delimited list of minor words that must always be lowercase except for the first word in the string.
- Second argument: the original string to be converted.
### Arguments (Other languages)

- First argument (required): the original string to be converted.
- Second argument (optional): space-delimited list of minor words that must always be lowercase except for the first word in the string. The JavaScript/CoffeeScript tests will pass undefined when this argument is unused.

### Example
```js
Kata.TitleCase("a an the of", "a clash of KINGS")   => "A Clash of Kings"
Kata.TitleCase("The In", "THE WIND IN THE WILLOWS") => "The Wind in the Willows"
Kata.TitleCase("the quick brown fox")               => "The Quick Brown Fox"
```

### 註

- 原題目的 Example 的 TitleCase 參數是相反的，正確的版本如下：

```js
Kata.TitleCase("a clash of KINGS", "a an the of")   => "A Clash of Kings"
Kata.TitleCase("THE WIND IN THE WILLOWS", "The In") => "The Wind in the Willows"
Kata.TitleCase("the quick brown fox")               => "The Quick Brown Fox"
```

---

### 中文大意

沒有例外字的情況下，首字母大寫，其餘小寫，有例外字情況下，都是小寫，不過第一個字不在例外裡面
