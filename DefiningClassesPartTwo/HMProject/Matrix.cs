using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Matrix<T>
    where T: struct
{
    private T[,] matrix;

    public Matrix(int rows, int columns)
    {
        matrix = new T[rows, columns];
    }
    public Matrix(T[,] matrix)
    {
        this.matrix = (dynamic)matrix.Clone();
    }
    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }
    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }
    public T this [int row, int col]
    {
        get
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                throw new IndexOutOfRangeException();
            }
            return matrix[row, col];
        }
        set
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                throw new IndexOutOfRangeException();
            }
            this.matrix[row, col] = value;
        }
    }
    public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
    {        
        Matrix<T> result = new Matrix<T>(m1.Rows, m1.Columns);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
            }
        }
        return result;
    }
    public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
    {
        Matrix<T> result = new Matrix<T>(m1.Rows, m1.Columns);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
            }
        }
        return result;
    }
    public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
    {
        Matrix<T> result = new Matrix<T>(m1.Rows, m1.Columns);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                dynamic sum = 0;
                for (int x = 0; x < m1.Columns; x++)
                {
                    sum = sum + (dynamic)m1[i, j] * (dynamic)m2[i, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }
}

