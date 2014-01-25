﻿
using UnityEngine;
using module.scene.utils;
namespace module.scene.tile
{
	class TileUitls
	{
        public static int TILE_SIZE = 44; //格子高度
        public static Vector3 getFlatCenterByPos(int pos) {
            int tx = PosUtil.getTx(pos);
            int ty = PosUtil.getTy(pos);
            int tz = PosUtil.getTz(pos);
			Vector3 v3 = indexToFlat2(tx, ty,tz);
            v3.y = v3.y + TILE_SIZE / 2;
            return v3;
		}

		public static Vector3 getFlatCenterByPosWithVertor3(int pos, Vector3 p, int defaultTileSize = 0)
        {
            defaultTileSize = defaultTileSize == 0 ? TILE_SIZE : defaultTileSize;
            int tx = PosUtil.getTx(pos);
            int ty = PosUtil.getTy(pos);
            int tz = PosUtil.getTz(pos);
			p = indexToFlat2WithPoint(tx, ty, tz, p, defaultTileSize);
            p.z = p.z + defaultTileSize / 2;
			return p;
        }

		private static Vector3 indexToFlat2(int tx, int ty , int tz) {
			float x = tx - tz;
			float y = ty;
			float z = (tx + tz) / 2;
            return new Vector3(x * TILE_SIZE, y * TILE_SIZE, z * TILE_SIZE);
		}

        private static Vector3 indexToFlat2WithPoint(int tx, int ty , int tz, Vector3 p,int defaultTileSize=0) {
            float x = tx - tz;
			float y = ty;
            float z = (tx + tz) / 2;
            
			p.x = x * defaultTileSize;
			p.y = y * defaultTileSize;
            p.z = z * defaultTileSize;
			return p;
		}
	}
}