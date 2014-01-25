namespace proto {
	public class m_pet_soul_hunt_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int hunt_times = 0;
		public object[] hunt_npcs;
		public object[] update_souls;
		public object[] npc_path;
		public int free_times = 0;
		public m_pet_soul_hunt_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_hunt";
		}
		public override string getClassName() {
			return "m_pet_soul_hunt_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"hunt_times", "int", "null"},new string[] {"hunt_npcs", "array", "int"},new string[] {"update_souls", "array", "p_pet_soul"},new string[] {"npc_path", "array", "int"},new string[] {"free_times", "int", "null"}};
		}
	}
}
