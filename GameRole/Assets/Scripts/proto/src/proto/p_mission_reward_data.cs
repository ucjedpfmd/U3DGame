namespace proto {
	public class p_mission_reward_data : Message
	{
		public object[] reward;
		public object[] prop;
		public p_mission_reward_data() {
		}
		public override string getClassName() {
			return "p_mission_reward_data";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"reward", "array", "p_key_value"},new string[] {"prop", "array", "p_mission_prop"}};
		}
	}
}
