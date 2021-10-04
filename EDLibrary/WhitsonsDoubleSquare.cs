using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDLibrary
{
    public class WhitsonsDoubleSquare
    {
        const string Alphabet = "abcdefghiklmnopqrstuvwxyz"; // i=j

        const int MatrixSize = 5;

        private static char[,] GetMatrix(string keyWord)
        {
            var matrixString = string.Concat(keyWord.ToLower(), Alphabet)
                .Replace("j", "i")
                .ToCharArray() //привожу к массиву символов
                .Distinct() //удаляет повторяющиеся элементы
                .ToArray();

            var reult = new char[MatrixSize, MatrixSize];

            for (var i = 0; i < MatrixSize; i++)
            {
                var arrayToCoppy = matrixString
                    .Skip(i * MatrixSize) // пропускаем определленое кол-во элементов
                    .Take(MatrixSize) //берём из массива 5 элементов
                    .ToArray();

                for (var j = 0; j < MatrixSize; j++)
                {
                    reult[i, j] = arrayToCoppy[j];
                }
            }

            return reult;
        }

        private static string MatrixToString(char[,] matrix)
        {
            var result = new StringBuilder();

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    result.Append($"{matrix[i, j]} ");
                }
                result.Append("\n");
            }

            return result.ToString();
        }

        private static List<string> CreateChunks(string phraze)
        {
            phraze = phraze.Replace(" ", string.Empty);

            if (phraze.Length % 2 != 0)
                phraze += 'a';

            var chunks = new List<string>();

            for (var i = 0; i < phraze.Length; i += 2)
            {
                chunks.Add(phraze.Substring(i, 2));//выделение подстроки
            }

            return chunks;
        }

        private static void GetIndexes(char[,] matrix, char serachSymbol, out int row, out int column)
        {
            row = matrix.GetLength(0);
            column = matrix.GetLength(1);
            var isFound = false;

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == serachSymbol)
                    {
                        row = i;
                        column = j;
                        isFound = true;
                        break;
                    }
                }
                if (isFound) break;
            }

            if (row == matrix.GetLength(0) || column == matrix.GetLength(1))
            {
                throw new Exception("Not founded");
            }
        }

        private static string InsertSpaces(string sourceString, string targetString)
        {
            var spacesIndexes = sourceString
                .Select((symol, index) => new { Symbol = symol, Index = index })
                .Where(el => char.IsWhiteSpace(el.Symbol))
                .Select(el => el.Index)
                .ToList();

            foreach (var item in spacesIndexes)
            {
                targetString = targetString.Insert(item, " ");
            }

            return targetString;
        }

        public static (string result, string firstMatrix, string secondMatrix) Encryption(string firstKey, string secondKey, string inputText)
        {
            var firstMatrix = GetMatrix(firstKey.Trim());
            var secondMatrix = GetMatrix(secondKey.Trim());//обрезать пробелы с концов

            var chunks = CreateChunks(inputText.Replace("j", "i").ToLower().Trim());
            var result = new StringBuilder();//нужно для того, чтобы каждый раз не создавалась новая строка, а изменялась текущая

            for (var i = 0; i < chunks.Count; i++)
            {
                GetIndexes(firstMatrix, chunks[i][0], out var firstSymbolRow, out var firstSymbolColumn);
                GetIndexes(secondMatrix, chunks[i][1], out var secondSymbolRow, out var secondSymbolColumn);

                if (firstSymbolRow == secondSymbolRow)
                {
                    result.Append(firstMatrix[firstSymbolRow, secondSymbolColumn]);
                    result.Append(secondMatrix[secondSymbolRow, firstSymbolColumn]);
                }
                else
                {
                    result.Append(firstMatrix[secondSymbolRow, firstSymbolColumn]);
                    result.Append(secondMatrix[firstSymbolRow, secondSymbolColumn]);
                }
            }

            return (InsertSpaces(inputText, result.ToString()), MatrixToString(firstMatrix), MatrixToString(secondMatrix));
        }

        public static (string result, string firstMatrix, string secondMatrix) Decryption(string firstKey, string secondKey, string inputText)
        {
            var firstMatrix = GetMatrix(secondKey.Trim());
            var secondMatrix = GetMatrix(firstKey.Trim());

            var chunks = CreateChunks(inputText.Replace("j", "i").ToLower().Trim());
            var result = new StringBuilder();

            for (var i = 0; i < chunks.Count; i++)
            {
                GetIndexes(firstMatrix, chunks[i][0], out var firstSymbolRow, out var firstSymbolColumn);
                GetIndexes(secondMatrix, chunks[i][1], out var secondSymbolRow, out var secondSymbolColumn);

                if (firstSymbolRow == secondSymbolRow)
                {
                    result.Append(firstMatrix[firstSymbolRow, secondSymbolColumn]);
                    result.Append(secondMatrix[secondSymbolRow, firstSymbolColumn]);
                }
                else
                {
                    result.Append(firstMatrix[secondSymbolRow, firstSymbolColumn]);
                    result.Append(secondMatrix[firstSymbolRow, secondSymbolColumn]);
                }
            }

            return (InsertSpaces(inputText, result.ToString()), MatrixToString(firstMatrix), MatrixToString(secondMatrix));
        }
    }
}
