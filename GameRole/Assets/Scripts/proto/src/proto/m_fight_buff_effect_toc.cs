namespace proto {
	public class m_fight_buff_effect_toc : Message
	{
		public double actor_id = 0;
		public int actor_type = 0;
		public object[] buff_effect;
		public int dst_left_hp = 0;
		public double src_id = 0;
		public int src_type = 0;
		public m_fight_buff_effect_toc() {
		}
		public override string getMethodName() {
			return "fight_buff_effect";
		}
		public override string getClassName() {
			return "m_fight_buff_effect_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_id", "double", "null"},new string[] {"actor_type", "int", "null"},new string[] {"buff_effect", "array", "p_buff_effect"},new string[] {"dst_left_hp", "int", "null"},new string[] {"src_id", "double", "null"},new string[] {"src_type", "int", "null"}};
		}
	}
}
