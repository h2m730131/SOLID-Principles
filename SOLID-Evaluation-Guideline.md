# [如何進行您的專案程式的 SOLID Principle 原則之評估方法](https://gist.github.com/vulcanlee/822ab34251ad1d9e346b27d535071244)

在這篇文章中，我們將分別針對 SOLID 的五個原則，說明如何檢驗您的程式碼，是否有符合這些原則的檢驗論述指引。也就是說，當您判斷一個程式，是否有符合 SOLID 各個原則或者其中一個原則，您可以使用這篇文章提出的指引，描述出您的看法。

# Single Responsibility Principle SRP

在 Wiki 定義 [Single Responsibility Principle](https://en.wikipedia.org/wiki/Single_responsibility_principle) 如下

> every module or class should have responsibility over a single part of the functionality provided by the software, and that responsibility should be entirely encapsulated by the class.
 
而在 Robert C. Martin 對於這個原則的描述為

> A class should have only one reason to change.

## 驗證步驟

在這裡，我們將需要進行 分析對象 與 分析理由 的論述

### 分析對象

我們在這裡採用 Robert C. Martin 的描述，因此，請您要指出要分析的類別是哪一個，也就是: 一個類別應該只有一個改變的理由！

> 類別 C

### 分析理由

因為 `responsibility as a reason to change` 責任將會定義為一個改變的理由，而要改變這個需求，有些時候會提早知道，而大部分的時候，您幾乎無法做到預測，這些變更的理由可能會來自於客戶的要求、PM的修正、當時環境的變更、公司的政策等等。

所以，請在這裡描述您認為這個類別究竟存在哪些責任，為什麼會有這樣的責任存在呢？

> 在類別 C 中，存在著 R 責任，會有 R 責任存在，是因為存在著 RC 變更理由
>
> 經過重構之後，在類別 C 中，僅存在著一個變更理由 (RC')，也就是具有一個責任 (R')
>
> 請依序把上述的 C, R , RC , RC' , R' 替換您的分析理由，若有多個責任，請分別描述出來

# Open Closed Principle OCP

在 Wiki 定義 [Open Closed Principle](https://en.wikipedia.org/wiki/Open%E2%80%93closed_principle) 如下

> software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification, that is, such an entity can allow its behaviour to be extended without modifying its source code.

在 Uncle Bob 的書中，對於 OCP ，定義 OCP 如下

> Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.

在最初的 OCP 提出者 Bertrand Meyer，定義 OCP 如下

> A module will be said to be open if it is still available for extension. For example, it should be possible to add fields to the data structures it contains, or new elements to the set of functions it performs.
>
> A module will be said to be closed if [it] is available for use by other modules. This assumes that the module has been given a well-defined, stable description (the interface in the sense of information hiding).[3]
> 
> Meyer's proposed solution to this dilemma relied on the notion of object-oriented inheritance (specifically implementation inheritance):
>
> A class is closed, since it may be compiled, stored in a library, baselined, and used by client classes. But it is also open, since any new class may use it as parent, adding new features. When a descendant class is defined, there is no need to change the original or to disturb its clients.

## 驗證步驟

在這裡，我們將需要進行 分析對象 與 分析理由 的論述

### 分析對象

根據該原則的定義，我們分析的對象會是 `software entities (classes, modules, functions, etc.)`，因此，請您要指出要分析的類別是哪一個

> 在軟體項目 E (可能是 類別、模組、函數)、開放 O 理由、封閉 C 理由
### 分析理由

請在這裡分別描述您認為存在著 開放 Open 與 封閉 Closed 的狀況

> 先描述為重構前的情況
> 
> 在 軟體項目 E
> 
> 開放 ： 為什麼在軟體項目 E 中，為什麼不可以擴展，其 開放 O 理由
>
> 封閉 ： 為什麼在軟體項目 E 中，為什麼不可以封閉修改，其 封閉 C 理由
>
> 經過重構之後，
> 
> 軟體項目 E
> 
> 開放 ： 為什麼在軟體項目 E 中，為什麼可以擴展，其 開放 O 理由
>
> 封閉 ： 為什麼在軟體項目 E 中，為什麼可以封閉修改，其 封閉 C 理由
>
> 請依序把上述的 E, O, C 替換您的分析結果

# Liskov Substitution Principle LSP

在 Wiki 定義 [Liskov Substitution Principle](https://en.wikipedia.org/wiki/Liskov_substitution_principle) 如下

> the Liskov substitution principle (LSP) is a particular definition of a subtyping relation, called (strong) behavioral subtyping, that was initially introduced by Barbara Liskov in a 1987 conference keynote address titled Data abstraction and hierarchy. It is a semantic rather than merely syntactic relation, because it intends to guarantee semantic interoperability of types in a hierarchy, object types in particular. Barbara Liskov and Jeannette Wing formulated the principle succinctly in a 1994 paper as follows:

在 Uncle Bob 的書中，對於 LSP ，定義 LSP 如下

> Subtypes must be substitutable for their base types.

在最初的 LSP 提出者 Liskov ，定義 LSP 如下

> if S is a subtype of T, then objects of type T in a program may be replaced with objects of type S without altering any of the desirable properties of that program.
> 
> What is wanted here is something like the following substitution property: If
for each object o1 of type S there is an object o2 of type T such that for all
programs P defined in terms of T, the behavior of P is unchanged when o1 is
substituted for o2 then S is a subtype of T.

## 驗證步驟

在這裡，我們將需要進行 分析對象 與 分析理由 的論述

### 分析對象

根據該原則的定義，我們分析的對象會是 subtype 子型別 與 base type 基底型別 和 有用到基底型別的程式碼，因此，請您要指出這兩個型別與其相關程式碼的那些地方與行為，是否違反了 LSP 的要求

> 程式碼 P ， 子型別 S ， 基底型別 T

### 分析理由

請將您的分析結果，在這裡描述

> 符合 ： 在程式碼 P ，對於 子型別 S ，是 可以替換 基底型別 T
>
> 違反 ： 在程式碼 P ，對於 子型別 S ，無法 可以替換 基底型別 T，理由是 R
>
> 請依序把上述的 P, S, T, R 替換您的分析結果

# Interface Segregation Principle ISP

在 Wiki 定義 [Interface Segregation Principle](https://en.wikipedia.org/wiki/Interface_segregation_principle) 如下

> no client should be forced to depend on methods it does not use.[1] ISP splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them.

在 Uncle Bob 的書中，對於 ISP ，定義 ISP 如下

> Classes whose interfaces are not cohesive have "fat" interface.
>
> 也可以說是
> 
> Clients should not be forced to depend upon interfaces that they do not use.

在 Uncle Bob 的網頁中，對於 ISP ，定義 ISP 如下

> Make fine grained interfaces that are client specific.

在最初的 ISP 提出者 Robert C. Martin 的 Object Mentor SOLID Design Papers Series

## 驗證步驟

在這裡，我們將需要進行 分析對象 與 分析理由 的論述

### 分析對象

根據該原則的定義，我們分析的對象會 Client 用戶端，也就是要使用這個介面的用戶端與 Interface  介面，也就是抽象化的介面

> 用戶端 C ， 介面 I , 方法 M

### 分析理由

請將您的分析結果，在這裡描述

> 對於 用戶端 C ， 相依於介面 I ，將不會用到該 介面 I 的甚麼 方法 M
>
> 請依序把上述的 C , I, M 替換您的分析結果

# Dependency Inversion Principle DIP

在 Wiki 定義 [Dependency Inversion Principle](https://en.wikipedia.org/wiki/Dependency_inversion_principle) 如下

> refers to a specific form of decoupling software modules. When following this principle, the conventional dependency relationships established from high-level, policy-setting modules to low-level, dependency modules are reversed, thus rendering high-level modules independent of the low-level module implementation details. 

在 Uncle Bob 的書中，對於 ISP ，定義 ISP 如下

> High-level modules should not depend on low-level modules.  Both should depend on abstractions.
>
> Abstractions should not depend on details.  Details should depend on abstractions.

## 驗證步驟

在這裡，我們將需要進行 分析對象 與 分析理由 的論述

### 分析對象

根據該原則的定義，我們分析出 高階模組 High-Level Module ， 低階模組 Low-Level Module ， 抽象 Abstraction ， 細節 Detail 

> 高階模組 H ， 低階模組 L ， 抽象 A ， 細節 D

### 分析理由

請將您的分析結果，在這裡描述

> 對於 高階模組 H 原先有相依於 低階模組 L ，經過重構之後 高階模組 H 相依於 抽象 A
>
> 對於 抽象 A 原本相依於 細節 D ，經過重構之後， 細節 D 相依於 抽象 B
>
> 請依序把上述的 H , L , A , D , B 替換您的分析結果
