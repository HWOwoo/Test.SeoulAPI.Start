매개인자 : yyyymmdd

입력받은 매개인자를 통해 해당 년-월-일에 서울시에서 제공하는 측정일자, 측정소명, 미세먼지, 오존, 이산화질소, 일산화탄소, 아황산가스 농도를 가져오는 콘솔프로그램
                writer.WriteLine($"측정일자: {msrDtDe}");
                writer.WriteLine($"측정소명: {msrSteNm}");
                writer.WriteLine($"미세먼지(㎍/㎥) : {pm10}");
                writer.WriteLine($"오존(ppm) : {o3}");
                writer.WriteLine($"이산화질소농도(ppm) : {no2}");
                writer.WriteLine($"일산화탄소농도(ppm) : {co}");
                writer.WriteLine($"아황산가스농도(ppm) : {so2}");
StreamWriter를 사용하여 txt파일에 해당 문자를 기록하여 남기는 방식이다.

제공하는 데이터는 Json형식으로 받아오고 해당 Json형식을 string으로 convert하여 컨트롤한다.

모든 기능이 완료되면 콘솔창에 완료 메시지를 출력
