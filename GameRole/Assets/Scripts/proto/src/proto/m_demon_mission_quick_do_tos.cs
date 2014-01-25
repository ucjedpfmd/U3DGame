namespace proto {
	public class m_demon_mission_quick_do_tos : Message
	{
		public int id = 0;
		public int star = 0;
		public int times = 0;
		public m_demon_mission_quick_do_tos() {
		}
		public override string getMethodName() {
			return "demon_mission_quick_do";
		}
		public override string getClassName() {
			return "m_demon_mission_quick_do_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"star", "int", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
