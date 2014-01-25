namespace proto {
	public class m_map_dropthing_pick_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int add_money = 0;
		public int money = 0;
		public int dropthingid = 0;
		public p_goods goods = null;
		public int num = 0;
		public m_map_dropthing_pick_toc() {
		}
		public override string getMethodName() {
			return "map_dropthing_pick";
		}
		public override string getClassName() {
			return "m_map_dropthing_pick_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"add_money", "int", "null"},new string[] {"money", "int", "null"},new string[] {"dropthingid", "int", "null"},new string[] {"goods", "p_goods", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
