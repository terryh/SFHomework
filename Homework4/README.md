<link href="https://fonts.googleapis.com/css2?family=Fira+Code&display=swap" rel="stylesheet">
<link href="../static/main.css" rel="stylesheet" />

## Homework4 (第二組)

### 組員

* 游X翰 4094W007
* 張X文 4094W010
* 李X成 4094W011
* 何X禹 4094W012
* 黃X賢 4094W008

程式邏輯
```{.cs .numberLines}
public string IsGoodStudent(string name, List<Student> students)
{
    foreach (var item in students)
    {
        if (item.Name == name && (
            (item.Bmi >= 18.5f && item.Bmi < 24.0f) || 
            item.Score >= 80.0f))
        {
            return "YES";
        } else if (item.Name == name) 
        {
            return "NO";
        }
    }
    // no found
    return "";
}
```

## Logical Expression Test Case

```{.cs}
/// students
_students = new List<Student>
    {
        // name, score, bmi
        new Student("Nick", 95.0f, 22.0f),
        new Student("Jack", 79.0f, 23.0f),
        new Student("Clark", 79.0f, 17.0f),
        new Student("Peter", 82.0f, 17.0f),
        new Student("John", 80.0f, 26.0f),
        new Student("Mary", 77.0f, 25.0f),
    };


if (item.Name == name && ((item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
```

A && ((B && C) || D)

* A => item.Name == name
* B => item.Bmi >= 18.5f
* C => item.Bmi < 24.0f
* D => item.Score >= 80.0f

<p class="pagebreak" />

## Predicate Coverage 

### test case 1 


A && ((B && C) || D) ==> True

1. input values: "Nick"
2. expected result: "YES"
3. test program's result: "YES"


### test case 2 

A && ((B && C) || D) ==> False

1. input values: "Eric"
2. expected result: ""
3. test program's result: ""

## Clause Coverage 

A && ((B && C) || D)


### test case 1 

A: True, B: True, C: True, D: True

1. input values: "Nick"
2. expected result: "YES"
3. test program's result: "YES"

### test case 2 


A: False, B: False, C: False, D: False

1. input values: "Eric"
2. expected result: ""
3. test program's result: ""


## Combinatorial Coverage 

if (item.Name == name && ((item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))

A && ((B && C) || D)

* A => item.Name == name
* B => item.Bmi >= 18.5f
* C => item.Bmi < 24.0f
* D => item.Score >= 80.0f

<p class="pagebreak" />

::::columns

:::column

### test case 1 

ABCD: 0000 0

1. input values: "Eric"
2. expected result: ""
3. test program's result: ""

### test case 2 

ABCD: 0001 1

1. input values: "Mike"
2. expected result: ""
3. test program's result: ""

### test case 3 

ABCD: 0010 2

1. input values: "Ted"
2. expected result: ""
3. test program's result: ""

### test case 4 

ABCD: 0011 3

1. input values: "William"
2. expected result: ""
3. test program's result: ""

### test case 5 

ABCD: 0100 4

1. input values: "Tom"
2. expected result: ""
3. test program's result: ""


### test case 6 

ABCD: 0101 5

1. input values: "Evon"
2. expected result: ""
3. test program's result: ""

:::
:::column

### test case 7 

ABCD: 0110 6

1. input values: "Jackson"
2. expected result: ""
3. test program's result: ""

### test case 8 

ABCD: 0111 7

1. input values: "Dino"
2. expected result: ""
3. test program's result: ""

### test case 9 

ABCD: 1000 8 

1. input values: "Mary"
2. expected result: "NO"
3. test program's result: "NO"

### test case 10 

ABCD: 1001 9

1. input values: "John"
2. expected result: "YES"
3. test program's result: "YES"

### test case 11 

ABCD: 1010 10

1. input values: "Clark"
2. expected result: "NO"
3. test program's result: "NO"

### test case 12 

ABCD: 1011 11

1. input values: "Peter"
2. expected result: "YES"
3. test program's result: "YES"

:::
::::

<p class="pagebreak" />

### test case 13 

ABCD: 1100 12

1. input values: "Mary"
2. expected result: "NO"
3. test program's result: "NO"

### test case 14 

ABCD: 1101 13

1. input values: "John"
2. expected result: "YES"
3. test program's result: "YES"

### test case 15 

ABCD: 1110 14

1. input values: "Jack"
2. expected result: "YES"
3. test program's result: "YES"

### test case 16 

ABCD: 1111 15

1. input values: "Nick"
2. expected result: "YES"
3. test program's result: "YES"


