#include "log2.h"
#include <iostream>

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
		else return "Не вожможно посчитать значение y1";
		return y1;
	};

	bool vihod2()
	{
		if (((x2 == 1) || (x2 == 0)) && ((x3 == 1) || (x3 == 0))) y2 = x2 && x3;
		else return "Не вожможно посчитать значение y2";
		return y2;
	};
};