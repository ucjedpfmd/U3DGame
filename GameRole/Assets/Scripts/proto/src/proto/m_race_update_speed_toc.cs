namespace proto {
	public class m_race_update_speed_toc : Message
	{
		public double role_id = 0;
		public int speed = 0;
		public m_race_update_speed_toc() {
		}
		public override string getMethodName() {
			return "race_update_speed";
		}
		public override string getClassName() {
			return "m_race_update_speed_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"speed", "int", "null"}};
		}
	}
}
