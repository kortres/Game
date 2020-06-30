using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    private RectInt rect;

    private int xMin, xMax;
    private int yMin, yMax;

    private bool isMainRoom;
    private bool infected;

    public Room(int xMin, int xMax, int yMin, int yMax)
    {
        this.xMin = xMin;
        this.xMax = xMax;
        this.yMin = yMin;
        this.yMax = yMax;
    }

    public int XMin { get => xMin; }
    public int XMax { get => xMax; }
    public int YMin { get => yMin; }
    public int YMax { get => yMax; }

    //public bool isRoomOverlaps(Room rm)
    //{
    //    if ((xMin < rm.XMax && xMax > rm.XMax) && (yMin < rm.yMin && yMax > rm.yMin)) // проверка на правый нижний угол комнаты
    //    {

    //    }
    //    else if ((xMin < rm.XMax && xMax > rm.XMax) && (yMin < rm.yMax && yMax > rm.yMax)) // проверка на правый верхний угол
    //    {

    //    }
    //    else if ((xMin < rm.XMin && xMax > rm.XMin) && (yMin < rm.yMax && yMax > rm.yMax)) // проаерка на левый верхний угол
    //    {

    //    }
    //    else if ((xMin < rm.XMin && xMax > rm.XMin) && (yMin < rm.yMax && yMax > rm.yMax)) // проаерка на левый нижний угол
    //    {

    //    }
    //}
}
