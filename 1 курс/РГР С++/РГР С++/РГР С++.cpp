#include <iostream>
#include <cmath>
#include <string>
#include <locale>

using namespace std;

class log2
{
private:
	bool x1, x2, x3, y1, y2;
public:
	log2(bool a, bool b, bool c, bool d, bool e)
	{
		x1 = a;
		x2 = b;
		x3 = c;
		y1 = d;
		y2 = e;
	};
	bool vihod1()
	{
		if (((x1 == 1) || (x1 == 0)) && ((x2 == 1) || (x2 == 0))) y1 = x1 && x2;
		else ;
		return y1;
	};

	bool vihod2()
	{
		if (((x2 == 1) || (x2 == 0)) && ((x3 == 1) || (x3 == 0))) y2 = x2 && x3;
		else return "Не вожможно посчитать значение y2";
		return y2;
	};
};

int main()
{
	bool x1, x2, x3, y1, y2;       //тип логических переменных
	setlocale(LC_ALL, "Russian");
	cout << "   Работу выполнила студентка 1 курса группы ИС-29" << endl;
	cout << "   Хазова Александра Сергеевна" << endl;
	cout << "   Вариант 21" << endl;
	cout << "   Текст задания: " << endl;
	cout << "    Напишите класс log2, описывающий логическую схему" << endl;
	cout << "    с тремя входами и двумя выходами" << endl;
	cout << "        х1_______1|----|" << endl;
	cout << "        x2________|&   |.___Y1" << endl;
	cout << "             |    |____|" << endl;
	cout << "             |" << endl;                      //логическая схема
	cout << "             |___2|----|" << endl;
	cout << "        x3________|&   |.__Y2" << endl;              
	cout << "                  |____|" << endl;

	cout << "Входные сигналы: " << endl; //по всему проекту на вход принимаются только значения 0 и 1
	cin >> x1;
	cin >> x2;
	cin >> x3;
	log2 v(x1, x2, x3, y1, y2);
	cout << "Выходные сигналы: " << endl;
	cout << "y1 = " << v.vihod1() << endl;
	cout << "y2 = " << v.vihod2() << endl;
	system("pause");
	return 0;
}