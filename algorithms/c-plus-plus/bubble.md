```c++
/*ներառում է iostream գրադարանը*/
#include <iostream>
/*ներառում է vector գրադարանը */
#include <vector>

/*ստեղծում է int տիպի main ֆունկցիա,իր լռելյայն(default) ընդունվող պառամետրերով,*/
/*արանց որի չի կարող աժխատել c++ կոդը*/
int main(int argc, char const *argv[]) {
  /*ստեղծում է int տիպի vector, vector֊ը դա մոդեռնիզացված array֊է*/
  std::vector <int> numbers;
  /*ուղակի արտածում է չակերտների մեջինը*/
  std::cout << "Enter 10 numbers" << std::endl;
  /*for֊ը դա ցիկլ է տվյալ դեպքում սկսում է 0֊ից ավառտվում 10֊ով*/
  for (int i = 0; i < 10; i++) {
    /*ստեղծում է int տիպի փոփոխական*/
    int n;
    /*ներմուծում է console֊ից, cin հրամանի և >> բիթային աջ տեղաշարժի օգնությամբ*/
    std::cin >> n;
    /*n փոփոխականի արժեքը push_back հրամանի օգնությամբ
     վերջից ավելացնում է numbers անունով vector֊ի մեջ*/
    numbers.push_back(n);
    /*for ցիկլի վերջ*/
  }
  /*ստեղծում է bool տիպի փոփոխական exit անունով և ինիցիալիզացնում է false առժեք*/
  bool exit = false;
  /*do֊while loop֊ի սկիզբն է do֊while֊ը նույնպես ցիկլ է*/
  do{
    /*ամեն ցիկլի սկզբում exit փոփոխականին վեռագրում է false*/
    exit = false;
    /*for ցիկլ է տվյալ դեպքում սկսում է 0֊ից ավառտվում 9֊ով*/
    for (int i = 0; i < 9; i++) {
      /*if ֆունկցիան ստուգում է, թե արդյոք numbers vector֊ի i֊երորդ անդամը
       մեծ է numbers vector֊ի (i + 1)֊երորդ անդամից,
        եթե այո ապա շարունակում է հաջորդ տողից*/
        if(numbers[i] > numbers[i + 1]){
          /*exit փոփոխականին վեռագրում է true*/
          exit = true;
          /*ստեղծում է int տիպի temp անունով փոփոխական և
          ինիցիալիզացնում է numbers vector֊ի i֊երորդ անդամի առժեքը*/
          int temp = numbers[i];
          /*numbers vector֊ի i֊երորդ անդամին վեռագրում է
          numbers vector֊ի (i + 1)֊երորդ անդամի առժեքը*/
          numbers[i] = numbers[i + 1];
          /*numbers vector֊ի (i + 1)֊երորդ անդամին
          վեռագրում է temp փոփոխականի առժեքը*/
          numbers[i + 1] = temp;
          /*այսպիսով վերեվի 3 տողով numbers vector֊ի i֊երորդ անդամի և
          numbers vector֊ի (i + 1)֊երորդ անդամի առժեէները տեղերով փոխեց
          if ֆունկցիաի վերջ*/
        }
        /*for ցիկլի ավառտ*/
    }
    /*do֊while loop֊ի վերջն է, վորտեղ ստուգում է ելքի պայմանը,
    տվյալ դեպքում ցիկլից դւրս կգա ետե exit փոփոխականը հավասարէ լինի false*/
}while(exit);
/*for ցիկլ է տվյալ դեպքում սկսում է 0֊ից ավառտվում numbers vector֊ի երկառությամբ*/
for (int i = 0; i < numbers.size(); i++) {
  /*առտածում է numbers vector֊ի i֊երորդ անդամը, cout հրամանի և
  << բիթային ձախ տեղաշարժի օգնությամբ*/
  std::cout << numbers[i] << '\t';
  /*for ցիկլի ավառտ*/
}
/* "\n" ֊ը հրաման է որը մեկ տող իջեցնում է console֊ոմ*/
std::cout << "\n";
/*return 0; տողը ոպեռացիոն համակրգին ասում է ցրագիրը բարեհաջող ավառտվել է*/
return 0;
}
```
