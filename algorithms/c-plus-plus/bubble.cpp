/*ներառում է iostream գրադարանը*/
#include <iostream>
/*ներառում է vector գրադարանը */
#include <vector>

/*ստեղծում է int տիպի main ֆունկցիա,իր լռելյայն(default) ընդունվող պարամետրերով,*/
/*առանց որի չի կարող աշխատել c++ կոդը*/
int main(int argc, char const *argv[]) {
  /*ստեղծում է int տիպի vector, vector֊ը դա մոդեռնիզացված array֊է*/
  std::vector <int> numbers;
  /*պարզապես արտածում է չակերտների միջև գրված տեքստը*/
  std::cout << "Enter 10 numbers" << std::endl;
  /*for֊ը դա ցիկլ է, տվյալ դեպքում սկսում է 0֊ից և ավարտվում 10֊ով*/
  for (int i = 0; i < 10; i++) {
    /*ստեղծում է int տիպի փոփոխական*/
    int n;
    /*ներմուծում է console֊ից, cin հրամանի և >> բիթային աջ տեղաշարժի օգնությամբ*/
    std::cin >> n;
    /*n փոփոխականի արժեքը push_back հրամանի օգնությամբ
     վերջից ավելացվում է numbers անունով vector֊ի մեջ*/
    numbers.push_back(n);
    /*for ցիկլի վերջ*/
  }
  /*ստեղծում է bool տիպի փոփոխական exit անունով և ինիցիալիզացնում է false արժեք*/
  bool exit = false;
  /*do֊while loop֊ի սկիզբն է: do֊while֊ը նույնպես ցիկլ է*/
  do{
    /*ամեն ցիկլի սկզբում exit փոփոխականին վերագրում է false*/
    exit = false;
    /*for ցիկլ է, տվյալ դեպքում սկսում է 0֊ից, ավարտվում 9֊ով*/
    for (int i = 0; i < 9; i++) {
      /*if-ը ստուգում է, թե արդյոք numbers vector֊ի i֊երորդ անդամը
       մեծ է numbers vector֊ի (i + 1)֊երորդ անդամից,
        եթե այո ապա շարունակում է հաջորդ տողից*/
        if(numbers[i] > numbers[i + 1]){
          /*exit փոփոխականին վերագրում է true*/
          exit = true;
          /*ստեղծում է int տիպի temp անունով փոփոխական և
          ինիցիալիզացնում է numbers vector֊ի i֊երորդ անդամի արժեքը*/
          int temp = numbers[i];
          /*numbers vector֊ի i֊երորդ անդամին վերագրում է
          numbers vector֊ի (i + 1)֊երորդ անդամի արժեքը*/
          numbers[i] = numbers[i + 1];
          /*numbers vector֊ի (i + 1)֊երորդ անդամին
          վերագրում է temp փոփոխականի արժեքը*/
          numbers[i + 1] = temp;
          /*այսպիսով վերևի 3 տողով numbers vector֊ի i֊երորդ անդամի և
          numbers vector֊ի (i + 1)֊երորդ անդամի արժեքները տեղերով փոխվեցին
          if-ի վերջ*/
        }
        /*for ցիկլի ավարտ*/
    }
    /*do֊while loop֊ի վերջն է, որտեղ ստուգում է ելքի պայմանը,
    տվյալ դեպքում ցիկլից դուրս կգա եթե exit փոփոխականը հավասար լինի false*/
}while(exit);
/*for ցիկլ է, տվյալ դեպքում սկսում է 0֊ից, ավարտվում numbers vector֊ի երկարությամբ*/
for (int i = 0; i < numbers.size(); i++) {
  /*արտածում է numbers vector֊ի i֊երորդ անդամը, cout հրամանի և
  << բիթային ձախ տեղաշարժի օգնությամբ*/
  std::cout << numbers[i] << '\t';
  /*for ցիկլի ավարտ*/
}
/* "\n"֊ը հրաման է, որը մեկ տող իջեցնում է console֊ում*/
std::cout << "\n";
/*return 0; տողը օպերացիոն համակարգին ասում է, որ ծրագիրը բարեհաջող ավարտվել է*/
return 0;
}
