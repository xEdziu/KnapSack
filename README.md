# Problem plecakowy w .NET 8.0
> Autor: Adrian Goral

## Wstęp
Celem projektu jest implementacja aplikacji w technologii .NET 8.0 rozwiązującej klasyczny problem optymalizacji - problem plecakowy. Projekt polega na stworzeniu aplikacji, która umożliwia użytkownikowi rozwiązanie problemu plecakowego, a także zapoznanie się z tworzeniem testów jednostkowych oraz graficznego interfejsu użytkownika (GUI).

## Opis problemu
Problem plecakowy polega na tym, aby z zestawu przedmiotów wybrać takie, które należy zapakować do plecaka, aby ich suma wartości była jak największa, jednocześnie nie przekraczając maksymalnej pojemności plecaka. Każdy przedmiot ma przypisaną wartość i wagę, a plecak ma określoną pojemność.

## Struktura projektu
Projekt składa się z kilku głównych komponentów:
1. **Problem.cs** - Klasa reprezentująca problem plecakowy, w której generowane są przedmioty oraz zaimplementowany jest algorytm zachłanny rozwiązujący problem.
2. **Item.cs** - Klasa reprezentująca pojedynczy przedmiot, zawierająca jego wartość i wagę.
3. **Result.cs** - Klasa przechowująca wynik rozwiązania, czyli przedmioty wybrane do plecaka oraz sumaryczną wagę i wartość.
4. **Program.cs** - Aplikacja konsolowa do generowania instancji problemu, rozwiązywania go oraz wyświetlania wyników.
5. **Form1.cs i Form1.Designer.cs** - GUI aplikacji, pozwalające użytkownikowi na interakcję z programem przy użyciu formularzy Windows Forms.

## Działanie programu
Po uruchomieniu aplikacji użytkownik zostanie poproszony o:
1. Wprowadzenie liczby przedmiotów.
2. Podanie nasionka (seed) do losowania wartości i wag przedmiotów.
3. Określenie pojemności plecaka.

Po wprowadzeniu danych aplikacja generuje przedmioty, a następnie oblicza optymalne rozwiązanie przy użyciu algorytmu zachłannego. Wyniki są prezentowane w postaci listy wybranych przedmiotów oraz ich sumarycznej wagi i wartości.

## Testy jednostkowe
Projekt zawiera zestaw testów jednostkowych (w pliku **UnitTests.cs**), które weryfikują poprawność:
- Generowania przedmiotów,
- Rozwiązywania problemu plecakowego w przypadku różnych pojemności plecaka,
- Sprawdzania, czy przedmioty są wybierane w sposób optymalny.

## Wykorzystane technologie
- .NET 8.0
- C#
- Windows Forms (GUI)
- MSTest (Testy jednostkowe)

## Podsumowanie
Projekt stanowi przykład aplikacji rozwiązującej problem plecakowy przy użyciu technologii .NET 8.0, obejmując nie tylko część algorytmiczną, ale także implementację testów jednostkowych i graficznego interfejsu użytkownika.
