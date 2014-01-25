namespace proto {
	public class m_treasure_hunt_tos : Message
	{
		public int map_id = 0;
		public int op_type = 0;
		public m_treasure_hunt_tos() {
		}
		public override string getMethodName() {
			return "treasure_hunt";
		}
		public override string getClassName() {
			return "m_treasure_hunt_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
