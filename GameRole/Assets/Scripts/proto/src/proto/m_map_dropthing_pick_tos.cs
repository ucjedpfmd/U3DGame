namespace proto {
	public class m_map_dropthing_pick_tos : Message
	{
		public int dropthingid = 0;
		public m_map_dropthing_pick_tos() {
		}
		public override string getMethodName() {
			return "map_dropthing_pick";
		}
		public override string getClassName() {
			return "m_map_dropthing_pick_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"dropthingid", "int", "null"}};
		}
	}
}
