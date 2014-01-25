namespace proto {
	public class m_fight_attack_tos : Message
	{
		public int target_pos = 0;
		public int skillid = 0;
		public double target_id = 0;
		public int target_type = 0;
		public int src_type = 1;
		public int dir = 0;
		public int auto_hook = 0;
		public m_fight_attack_tos() {
		}
		public override string getMethodName() {
			return "fight_attack";
		}
		public override string getClassName() {
			return "m_fight_attack_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_pos", "int", "null"},new string[] {"skillid", "int", "null"},new string[] {"target_id", "double", "null"},new string[] {"target_type", "int", "null"},new string[] {"src_type", "int", "null"},new string[] {"dir", "int", "null"},new string[] {"auto_hook", "int", "null"}};
		}
	}
}
