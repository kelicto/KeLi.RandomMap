using System;

using static KeLi.RandomMap.Properties.Resources;

namespace KeLi.RandomMap;

public class Map
{
    private readonly string[,] _data;

    public Map(int width, int height)
    {
        _data = new string[width, height];
    }

    private void Initial()
    {
        for (var i = 0; i < _data.GetLength(0); i++)
        for (var j = 0; j < _data.GetLength(1); j++)
            _data[i, j] = _Space;
    }

    private static int GetRandomNum(int max)
    {
        return RandomMath.RandomMath.GetRealRandomInt(0, max);
    }

    public void Render()
    {
        if (_data is null)
            throw new NullReferenceException(nameof(_data));

        for (var i = 0; i < _data.GetLength(0); i++)
        {
            for (var j = 0; j < _data.GetLength(1); j++)
                Console.Write(_data[i, j]);

            Console.WriteLine();
        }
    }

    public void Create()
    {
        Initial();
        CreateGrass();
        CreateTree();
        CreateWilderness();
        CreateRabbit();
        CreateWolf();
    }

    private void CreateGrass()
    {
        for (var i = 0; i < _data.Length / 3 * 2; i++)
        {
            var flag = true;

            while (flag)
            {
                var x = GetRandomNum(_data.GetLength(0) - 1);
                var y = GetRandomNum(_data.GetLength(1) - 1);

                if (_data[x, y] == _Space)
                {
                    _data[x, y] = _Grass;
                    flag = false;
                }
            }
        }
    }

    private void CreateTree()
    {
        for (var i = 0; i < _data.Length / 3 * 2 / 3; i++)
        {
            var flag = true;

            while (flag)
            {
                var x = GetRandomNum(_data.GetLength(0) - 1);
                var y = GetRandomNum(_data.GetLength(1) - 1);

                if (_data[x, y] == _Space)
                {
                    _data[x, y] = _Tree;
                    flag = false;
                }
            }
        }
    }

    private void CreateWilderness()
    {
        for (var i = 0; i < _data.Length / 3 * 2 / 3 / 3; i++)
        {
            var flag = true;

            while (flag)
            {
                var x = GetRandomNum(_data.GetLength(0) - 1);
                var y = GetRandomNum(_data.GetLength(1) - 1);

                if (_data[x, y] == _Space)
                {
                    _data[x, y] = _Wilderness;
                    flag = false;
                }
            }
        }
    }

    private void CreateRabbit()
    {
        for (var i = 0; i < _data.Length / 3 * 2 / 3 / 3 / 3 / 3; i++)
        {
            var flag = true;

            while (flag)
            {
                var x = GetRandomNum(_data.GetLength(0) - 1);
                var y = GetRandomNum(_data.GetLength(1) - 1);

                if (_data[x, y] == _Space)
                {
                    _data[x, y] = _Rabbit;
                    flag = false;
                }
            }
        }
    }

    private void CreateWolf()
    {
        for (var i = 0; i < _data.Length / 3 * 2 / 3 / 3 / 3 / 3 / 3; i++)
        {
            var flag = true;

            while (flag)
            {
                var x = GetRandomNum(_data.GetLength(0) - 1);
                var y = GetRandomNum(_data.GetLength(1) - 1);

                if (_data[x, y] == _Space)
                {
                    _data[x, y] = _Wolf;
                    flag = false;
                }
            }
        }
    }
}