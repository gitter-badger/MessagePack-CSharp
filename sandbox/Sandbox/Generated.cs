#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Resolvers
{
    using System;
    using MessagePack;

    public class GeneratedResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new GeneratedResolver();

        GeneratedResolver()
        {

        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> formatter;

            static FormatterCache()
            {
                var f = GeneratedResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class GeneratedResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static GeneratedResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(34)
            {
                {typeof(global::SharedData.ByteEnum), 0 },
                {typeof(global::SharedData.IUnionChecker), 1 },
                {typeof(global::SharedData.IUnionChecker2), 2 },
                {typeof(global::SharedData.IIVersioningUnion), 3 },
                {typeof(global::SharedData.FirstSimpleData), 4 },
                {typeof(global::SharedData.SimlpeStringKeyData), 5 },
                {typeof(global::SharedData.SimpleStructIntKeyData), 6 },
                {typeof(global::SharedData.SimpleStructStringKeyData), 7 },
                {typeof(global::SharedData.SimpleIntKeyData), 8 },
                {typeof(global::SharedData.Vector2), 9 },
                {typeof(global::SharedData.EmptyClass), 10 },
                {typeof(global::SharedData.EmptyStruct), 11 },
                {typeof(global::SharedData.Version1), 12 },
                {typeof(global::SharedData.Version2), 13 },
                {typeof(global::SharedData.Version0), 14 },
                {typeof(global::SharedData.HolderV1), 15 },
                {typeof(global::SharedData.HolderV2), 16 },
                {typeof(global::SharedData.HolderV0), 17 },
                {typeof(global::SharedData.Callback1), 18 },
                {typeof(global::SharedData.Callback1_2), 19 },
                {typeof(global::SharedData.Callback2), 20 },
                {typeof(global::SharedData.Callback2_2), 21 },
                {typeof(global::SharedData.MySubUnion1), 22 },
                {typeof(global::SharedData.MySubUnion2), 23 },
                {typeof(global::SharedData.MySubUnion3), 24 },
                {typeof(global::SharedData.MySubUnion4), 25 },
                {typeof(global::SharedData.VersioningUnion), 26 },
                {typeof(global::SharedData.MyClass), 27 },
                {typeof(global::SharedData.VersionBlockTest), 28 },
                {typeof(global::SharedData.UnVersionBlockTest), 29 },
                {typeof(global::SharedData.Empty1), 30 },
                {typeof(global::SharedData.Empty2), 31 },
                {typeof(global::SharedData.NonEmpty1), 32 },
                {typeof(global::SharedData.NonEmpty2), 33 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new MessagePack.Formatters.SharedData.ByteEnumFormatter();
                case 1: return new MessagePack.Formatters.SharedData.IUnionCheckerFormatter();
                case 2: return new MessagePack.Formatters.SharedData.IUnionChecker2Formatter();
                case 3: return new MessagePack.Formatters.SharedData.IIVersioningUnionFormatter();
                case 4: return new MessagePack.Formatters.SharedData.FirstSimpleDataFormatter();
                case 5: return new MessagePack.Formatters.SharedData.SimlpeStringKeyDataFormatter();
                case 6: return new MessagePack.Formatters.SharedData.SimpleStructIntKeyDataFormatter();
                case 7: return new MessagePack.Formatters.SharedData.SimpleStructStringKeyDataFormatter();
                case 8: return new MessagePack.Formatters.SharedData.SimpleIntKeyDataFormatter();
                case 9: return new MessagePack.Formatters.SharedData.Vector2Formatter();
                case 10: return new MessagePack.Formatters.SharedData.EmptyClassFormatter();
                case 11: return new MessagePack.Formatters.SharedData.EmptyStructFormatter();
                case 12: return new MessagePack.Formatters.SharedData.Version1Formatter();
                case 13: return new MessagePack.Formatters.SharedData.Version2Formatter();
                case 14: return new MessagePack.Formatters.SharedData.Version0Formatter();
                case 15: return new MessagePack.Formatters.SharedData.HolderV1Formatter();
                case 16: return new MessagePack.Formatters.SharedData.HolderV2Formatter();
                case 17: return new MessagePack.Formatters.SharedData.HolderV0Formatter();
                case 18: return new MessagePack.Formatters.SharedData.Callback1Formatter();
                case 19: return new MessagePack.Formatters.SharedData.Callback1_2Formatter();
                case 20: return new MessagePack.Formatters.SharedData.Callback2Formatter();
                case 21: return new MessagePack.Formatters.SharedData.Callback2_2Formatter();
                case 22: return new MessagePack.Formatters.SharedData.MySubUnion1Formatter();
                case 23: return new MessagePack.Formatters.SharedData.MySubUnion2Formatter();
                case 24: return new MessagePack.Formatters.SharedData.MySubUnion3Formatter();
                case 25: return new MessagePack.Formatters.SharedData.MySubUnion4Formatter();
                case 26: return new MessagePack.Formatters.SharedData.VersioningUnionFormatter();
                case 27: return new MessagePack.Formatters.SharedData.MyClassFormatter();
                case 28: return new MessagePack.Formatters.SharedData.VersionBlockTestFormatter();
                case 29: return new MessagePack.Formatters.SharedData.UnVersionBlockTestFormatter();
                case 30: return new MessagePack.Formatters.SharedData.Empty1Formatter();
                case 31: return new MessagePack.Formatters.SharedData.Empty2Formatter();
                case 32: return new MessagePack.Formatters.SharedData.NonEmpty1Formatter();
                case 33: return new MessagePack.Formatters.SharedData.NonEmpty2Formatter();
                default: return null;
            }
        }
    }
}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.SharedData
{
    using System;
    using MessagePack;

    public sealed class ByteEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.ByteEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::SharedData.ByteEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteByte(ref bytes, offset, (Byte)value);
        }
        
        public global::SharedData.ByteEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::SharedData.ByteEnum)MessagePackBinary.ReadByte(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.SharedData
{
    using System;
	using System.Collections.Generic;
    using MessagePack;

    public sealed class IUnionCheckerFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.IUnionChecker>
    {
		readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;
		readonly Dictionary<int, int> keyToJumpMap;

		public IUnionCheckerFormatter()
		{
			this.typeToKeyAndJumpMap = new Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>(4, global::MessagePack.Internal.RuntimeTypeHandleEqualityComparer.Default)
			{
				{ typeof(global::SharedData.MySubUnion1).TypeHandle, new KeyValuePair<int, int>(0, 0) },
				{ typeof(global::SharedData.MySubUnion2).TypeHandle, new KeyValuePair<int, int>(1, 1) },
				{ typeof(global::SharedData.MySubUnion3).TypeHandle, new KeyValuePair<int, int>(2, 2) },
				{ typeof(global::SharedData.MySubUnion4).TypeHandle, new KeyValuePair<int, int>(3, 3) },
			};
			this.keyToJumpMap = new Dictionary<int, int>(4)
			{
				{ 0, 0 },
				{ 1, 1 },
				{ 2, 2 },
				{ 3, 3 },
			};
		}

        public int Serialize(ref byte[] bytes, int offset, global::SharedData.IUnionChecker value, global::MessagePack.IFormatterResolver formatterResolver)
        {
			KeyValuePair<int, int> keyValuePair;
			if (value != null && this.typeToKeyAndJumpMap.TryGetValue(value.GetType().TypeHandle, out keyValuePair))
			{
				var startOffset = offset;
				offset += MessagePackBinary.WriteFixedArrayHeaderUnsafe(ref bytes, offset, 2);
				offset += MessagePackBinary.WriteInt32(ref bytes, offset, keyValuePair.Key);
				switch (keyValuePair.Value)
				{
					case 0:
						offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion1>().Serialize(ref bytes, offset, (global::SharedData.MySubUnion1)value, formatterResolver);
						break;
					case 1:
						offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion2>().Serialize(ref bytes, offset, (global::SharedData.MySubUnion2)value, formatterResolver);
						break;
					case 2:
						offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion3>().Serialize(ref bytes, offset, (global::SharedData.MySubUnion3)value, formatterResolver);
						break;
					case 3:
						offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion4>().Serialize(ref bytes, offset, (global::SharedData.MySubUnion4)value, formatterResolver);
						break;
					default:
						break;
				}

				return offset - startOffset;
			}

			return MessagePackBinary.WriteNil(ref bytes, offset);
        }
        
        public global::SharedData.IUnionChecker Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (MessagePackBinary.IsNil(bytes, offset))
			{
				readSize = 1;
				return null;
			}

			var startOffset = offset;
			
			if (MessagePackBinary.ReadArrayHeader(bytes, offset, out readSize) != 2)
			{
				throw new InvalidOperationException("Invalid Union data was detected. Type:global::SharedData.IUnionChecker");
			}
			offset += readSize;

			var key = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
			offset += readSize;

			global::SharedData.IUnionChecker result = null;
			switch (key)
			{
				case 0:
					result = (global::SharedData.IUnionChecker)formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion1>().Deserialize(bytes, offset, formatterResolver, out readSize);
					offset += readSize;
					break;
				case 1:
					result = (global::SharedData.IUnionChecker)formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion2>().Deserialize(bytes, offset, formatterResolver, out readSize);
					offset += readSize;
					break;
				case 2:
					result = (global::SharedData.IUnionChecker)formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion3>().Deserialize(bytes, offset, formatterResolver, out readSize);
					offset += readSize;
					break;
				case 3:
					result = (global::SharedData.IUnionChecker)formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion4>().Deserialize(bytes, offset, formatterResolver, out readSize);
					offset += readSize;
					break;
				default:
					offset += MessagePackBinary.ReadNextBlock(bytes, offset);
					break;
			}
			
			readSize = offset - startOffset;
			
			return result;
        }
    }

    public sealed class IUnionChecker2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.IUnionChecker2>
    {
		readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;
		readonly Dictionary<int, int> keyToJumpMap;

		public IUnionChecker2Formatter()
		{
			this.typeToKeyAndJumpMap = new Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>(4, global::MessagePack.Internal.RuntimeTypeHandleEqualityComparer.Default)
			{
				{ typeof(global::SharedData.MySubUnion2).TypeHandle, new KeyValuePair<int, int>(31, 0) },
				{ typeof(global::SharedData.MySubUnion3).TypeHandle, new KeyValuePair<int, int>(42, 1) },
				{ typeof(global::SharedData.MySubUnion4).TypeHandle, new KeyValuePair<int, int>(63, 2) },
				{ typeof(global::SharedData.MySubUnion1).TypeHandle, new KeyValuePair<int, int>(120, 3) },
			};
			this.keyToJumpMap = new Dictionary<int, int>(4)
			{
				{ 31, 0 },
				{ 42, 1 },
				{ 63, 2 },
				{ 120, 3 },
			};
		}

        public int Serialize(ref byte[] bytes, int offset, global::SharedData.IUnionChecker2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
			KeyValuePair<int, int> keyValuePair;
			if (value != null && this.typeToKeyAndJumpMap.TryGetValue(value.GetType().TypeHandle, out keyValuePair))
			{
				var startOffset = offset;
				offset += MessagePackBinary.WriteFixedArrayHeaderUnsafe(ref bytes, offset, 2);
				offset += MessagePackBinary.WriteInt32(ref bytes, offset, keyValuePair.Key);
				switch (keyValuePair.Value)
				{
					case 0:
						offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion2>().Serialize(ref bytes, offset, (global::SharedData.MySubUnion2)value, formatterResolver);
						break;
					case 1:
						offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion3>().Serialize(ref bytes, offset, (global::SharedData.MySubUnion3)value, formatterResolver);
						break;
					case 2:
						offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion4>().Serialize(ref bytes, offset, (global::SharedData.MySubUnion4)value, formatterResolver);
						break;
					case 3:
						offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion1>().Serialize(ref bytes, offset, (global::SharedData.MySubUnion1)value, formatterResolver);
						break;
					default:
						break;
				}

				return offset - startOffset;
			}

			return MessagePackBinary.WriteNil(ref bytes, offset);
        }
        
        public global::SharedData.IUnionChecker2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (MessagePackBinary.IsNil(bytes, offset))
			{
				readSize = 1;
				return null;
			}

			var startOffset = offset;
			
			if (MessagePackBinary.ReadArrayHeader(bytes, offset, out readSize) != 2)
			{
				throw new InvalidOperationException("Invalid Union data was detected. Type:global::SharedData.IUnionChecker2");
			}
			offset += readSize;

			var key = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
			offset += readSize;

			global::SharedData.IUnionChecker2 result = null;
			switch (key)
			{
				case 0:
					result = (global::SharedData.IUnionChecker2)formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion2>().Deserialize(bytes, offset, formatterResolver, out readSize);
					offset += readSize;
					break;
				case 1:
					result = (global::SharedData.IUnionChecker2)formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion3>().Deserialize(bytes, offset, formatterResolver, out readSize);
					offset += readSize;
					break;
				case 2:
					result = (global::SharedData.IUnionChecker2)formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion4>().Deserialize(bytes, offset, formatterResolver, out readSize);
					offset += readSize;
					break;
				case 3:
					result = (global::SharedData.IUnionChecker2)formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion1>().Deserialize(bytes, offset, formatterResolver, out readSize);
					offset += readSize;
					break;
				default:
					offset += MessagePackBinary.ReadNextBlock(bytes, offset);
					break;
			}
			
			readSize = offset - startOffset;
			
			return result;
        }
    }

    public sealed class IIVersioningUnionFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.IIVersioningUnion>
    {
		readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;
		readonly Dictionary<int, int> keyToJumpMap;

		public IIVersioningUnionFormatter()
		{
			this.typeToKeyAndJumpMap = new Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>(1, global::MessagePack.Internal.RuntimeTypeHandleEqualityComparer.Default)
			{
				{ typeof(global::SharedData.MySubUnion1).TypeHandle, new KeyValuePair<int, int>(0, 0) },
			};
			this.keyToJumpMap = new Dictionary<int, int>(1)
			{
				{ 0, 0 },
			};
		}

        public int Serialize(ref byte[] bytes, int offset, global::SharedData.IIVersioningUnion value, global::MessagePack.IFormatterResolver formatterResolver)
        {
			KeyValuePair<int, int> keyValuePair;
			if (value != null && this.typeToKeyAndJumpMap.TryGetValue(value.GetType().TypeHandle, out keyValuePair))
			{
				var startOffset = offset;
				offset += MessagePackBinary.WriteFixedArrayHeaderUnsafe(ref bytes, offset, 2);
				offset += MessagePackBinary.WriteInt32(ref bytes, offset, keyValuePair.Key);
				switch (keyValuePair.Value)
				{
					case 0:
						offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion1>().Serialize(ref bytes, offset, (global::SharedData.MySubUnion1)value, formatterResolver);
						break;
					default:
						break;
				}

				return offset - startOffset;
			}

			return MessagePackBinary.WriteNil(ref bytes, offset);
        }
        
        public global::SharedData.IIVersioningUnion Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (MessagePackBinary.IsNil(bytes, offset))
			{
				readSize = 1;
				return null;
			}

			var startOffset = offset;
			
			if (MessagePackBinary.ReadArrayHeader(bytes, offset, out readSize) != 2)
			{
				throw new InvalidOperationException("Invalid Union data was detected. Type:global::SharedData.IIVersioningUnion");
			}
			offset += readSize;

			var key = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
			offset += readSize;

			global::SharedData.IIVersioningUnion result = null;
			switch (key)
			{
				case 0:
					result = (global::SharedData.IIVersioningUnion)formatterResolver.GetFormatterWithVerify<global::SharedData.MySubUnion1>().Deserialize(bytes, offset, formatterResolver, out readSize);
					offset += readSize;
					break;
				default:
					offset += MessagePackBinary.ReadNextBlock(bytes, offset);
					break;
			}
			
			readSize = offset - startOffset;
			
			return result;
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.SharedData
{
    using System;
    using MessagePack;


    public sealed class FirstSimpleDataFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.FirstSimpleData>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public FirstSimpleDataFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(3)
            {
                { "Prop1", 0},
                { "Prop2", 1},
                { "Prop3", 2},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.FirstSimpleData value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 3);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop1", 5);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Prop1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop2", 5);
            offset += MessagePackBinary.WriteString(ref bytes, offset, value.Prop2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop3", 5);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Prop3);
            return offset - startOffset;
        }

        public global::SharedData.FirstSimpleData Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __Prop1__ = default(int);
            var __Prop2__ = default(string);
            var __Prop3__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __Prop1__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __Prop2__ = MessagePackBinary.ReadString(bytes, offset, out readSize);
                        break;
                    case 2:
                        __Prop3__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.FirstSimpleData();
            ____result.Prop1 = __Prop1__;
            ____result.Prop2 = __Prop2__;
            ____result.Prop3 = __Prop3__;
            return ____result;
        }
    }


    public sealed class SimlpeStringKeyDataFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.SimlpeStringKeyData>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public SimlpeStringKeyDataFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(3)
            {
                { "Prop1", 0},
                { "Prop2", 1},
                { "Prop3", 2},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.SimlpeStringKeyData value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 3);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop1", 5);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Prop1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop2", 5);
            offset += formatterResolver.GetFormatterWithVerify<global::SharedData.ByteEnum>().Serialize(ref bytes, offset, value.Prop2, formatterResolver);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop3", 5);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Prop3);
            return offset - startOffset;
        }

        public global::SharedData.SimlpeStringKeyData Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __Prop1__ = default(int);
            var __Prop2__ = default(global::SharedData.ByteEnum);
            var __Prop3__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __Prop1__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __Prop2__ = formatterResolver.GetFormatterWithVerify<global::SharedData.ByteEnum>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 2:
                        __Prop3__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.SimlpeStringKeyData();
            ____result.Prop1 = __Prop1__;
            ____result.Prop2 = __Prop2__;
            ____result.Prop3 = __Prop3__;
            return ____result;
        }
    }


    public sealed class SimpleStructIntKeyDataFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.SimpleStructIntKeyData>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public SimpleStructIntKeyDataFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(3)
            {
                { "X", 0},
                { "Y", 1},
                { "BytesSpecial", 2},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.SimpleStructIntKeyData value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 3);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "X", 1);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.X);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Y", 1);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Y);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "BytesSpecial", 12);
            offset += MessagePackBinary.WriteBytes(ref bytes, offset, value.BytesSpecial);
            return offset - startOffset;
        }

        public global::SharedData.SimpleStructIntKeyData Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __X__ = default(int);
            var __Y__ = default(int);
            var __BytesSpecial__ = default(byte[]);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __X__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __Y__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 2:
                        __BytesSpecial__ = MessagePackBinary.ReadBytes(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.SimpleStructIntKeyData();
            ____result.X = __X__;
            ____result.Y = __Y__;
            ____result.BytesSpecial = __BytesSpecial__;
            return ____result;
        }
    }


    public sealed class SimpleStructStringKeyDataFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.SimpleStructStringKeyData>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public SimpleStructStringKeyDataFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(2)
            {
                { "X", 0},
                { "Y", 1},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.SimpleStructStringKeyData value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "X", 1);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.X);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Y", 1);
            offset += formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref bytes, offset, value.Y, formatterResolver);
            return offset - startOffset;
        }

        public global::SharedData.SimpleStructStringKeyData Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __X__ = default(int);
            var __Y__ = default(int[]);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __X__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __Y__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.SimpleStructStringKeyData();
            ____result.X = __X__;
            ____result.Y = __Y__;
            return ____result;
        }
    }


    public sealed class SimpleIntKeyDataFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.SimpleIntKeyData>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public SimpleIntKeyDataFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(7)
            {
                { "Prop1", 0},
                { "Prop2", 1},
                { "Prop3", 2},
                { "Prop4", 3},
                { "Prop5", 4},
                { "Prop6", 5},
                { "BytesSpecial", 6},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.SimpleIntKeyData value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 7);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop1", 5);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Prop1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop2", 5);
            offset += formatterResolver.GetFormatterWithVerify<global::SharedData.ByteEnum>().Serialize(ref bytes, offset, value.Prop2, formatterResolver);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop3", 5);
            offset += MessagePackBinary.WriteString(ref bytes, offset, value.Prop3);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop4", 5);
            offset += formatterResolver.GetFormatterWithVerify<global::SharedData.SimlpeStringKeyData>().Serialize(ref bytes, offset, value.Prop4, formatterResolver);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop5", 5);
            offset += formatterResolver.GetFormatterWithVerify<global::SharedData.SimpleStructIntKeyData>().Serialize(ref bytes, offset, value.Prop5, formatterResolver);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Prop6", 5);
            offset += formatterResolver.GetFormatterWithVerify<global::SharedData.SimpleStructStringKeyData>().Serialize(ref bytes, offset, value.Prop6, formatterResolver);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "BytesSpecial", 12);
            offset += MessagePackBinary.WriteBytes(ref bytes, offset, value.BytesSpecial);
            return offset - startOffset;
        }

        public global::SharedData.SimpleIntKeyData Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __Prop1__ = default(int);
            var __Prop2__ = default(global::SharedData.ByteEnum);
            var __Prop3__ = default(string);
            var __Prop4__ = default(global::SharedData.SimlpeStringKeyData);
            var __Prop5__ = default(global::SharedData.SimpleStructIntKeyData);
            var __Prop6__ = default(global::SharedData.SimpleStructStringKeyData);
            var __BytesSpecial__ = default(byte[]);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __Prop1__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __Prop2__ = formatterResolver.GetFormatterWithVerify<global::SharedData.ByteEnum>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 2:
                        __Prop3__ = MessagePackBinary.ReadString(bytes, offset, out readSize);
                        break;
                    case 3:
                        __Prop4__ = formatterResolver.GetFormatterWithVerify<global::SharedData.SimlpeStringKeyData>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 4:
                        __Prop5__ = formatterResolver.GetFormatterWithVerify<global::SharedData.SimpleStructIntKeyData>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 5:
                        __Prop6__ = formatterResolver.GetFormatterWithVerify<global::SharedData.SimpleStructStringKeyData>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 6:
                        __BytesSpecial__ = MessagePackBinary.ReadBytes(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.SimpleIntKeyData();
            ____result.Prop1 = __Prop1__;
            ____result.Prop2 = __Prop2__;
            ____result.Prop3 = __Prop3__;
            ____result.Prop4 = __Prop4__;
            ____result.Prop5 = __Prop5__;
            ____result.Prop6 = __Prop6__;
            ____result.BytesSpecial = __BytesSpecial__;
            return ____result;
        }
    }


    public sealed class Vector2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Vector2>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Vector2Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(2)
            {
                { "X", 0},
                { "Y", 1},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Vector2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "X", 1);
            offset += MessagePackBinary.WriteSingle(ref bytes, offset, value.X);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Y", 1);
            offset += MessagePackBinary.WriteSingle(ref bytes, offset, value.Y);
            return offset - startOffset;
        }

        public global::SharedData.Vector2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __X__ = default(float);
            var __Y__ = default(float);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __X__ = MessagePackBinary.ReadSingle(bytes, offset, out readSize);
                        break;
                    case 1:
                        __Y__ = MessagePackBinary.ReadSingle(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Vector2(__X__, __Y__);
            return ____result;
        }
    }


    public sealed class EmptyClassFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.EmptyClass>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public EmptyClassFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(0)
            {
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.EmptyClass value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 0);
            return offset - startOffset;
        }

        public global::SharedData.EmptyClass Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;


            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.EmptyClass();
            return ____result;
        }
    }


    public sealed class EmptyStructFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.EmptyStruct>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public EmptyStructFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(0)
            {
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.EmptyStruct value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 0);
            return offset - startOffset;
        }

        public global::SharedData.EmptyStruct Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;


            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.EmptyStruct();
            return ____result;
        }
    }


    public sealed class Version1Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Version1>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Version1Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(3)
            {
                { "MyProperty1", 0},
                { "MyProperty2", 1},
                { "MyProperty3", 2},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Version1 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 3);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty1", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty2", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty3", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty3);
            return offset - startOffset;
        }

        public global::SharedData.Version1 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty1__ = default(int);
            var __MyProperty2__ = default(int);
            var __MyProperty3__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty1__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __MyProperty2__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 2:
                        __MyProperty3__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Version1();
            ____result.MyProperty1 = __MyProperty1__;
            ____result.MyProperty2 = __MyProperty2__;
            ____result.MyProperty3 = __MyProperty3__;
            return ____result;
        }
    }


    public sealed class Version2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Version2>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Version2Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(4)
            {
                { "MyProperty1", 0},
                { "MyProperty2", 1},
                { "MyProperty3", 2},
                { "MyProperty5", 3},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Version2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 4);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty1", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty2", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty3", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty3);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty5", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty5);
            return offset - startOffset;
        }

        public global::SharedData.Version2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty1__ = default(int);
            var __MyProperty2__ = default(int);
            var __MyProperty3__ = default(int);
            var __MyProperty5__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty1__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __MyProperty2__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 2:
                        __MyProperty3__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 3:
                        __MyProperty5__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Version2();
            ____result.MyProperty1 = __MyProperty1__;
            ____result.MyProperty2 = __MyProperty2__;
            ____result.MyProperty3 = __MyProperty3__;
            ____result.MyProperty5 = __MyProperty5__;
            return ____result;
        }
    }


    public sealed class Version0Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Version0>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Version0Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "MyProperty1", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Version0 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty1", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty1);
            return offset - startOffset;
        }

        public global::SharedData.Version0 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty1__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty1__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Version0();
            ____result.MyProperty1 = __MyProperty1__;
            return ____result;
        }
    }


    public sealed class HolderV1Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.HolderV1>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public HolderV1Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(2)
            {
                { "MyProperty1", 0},
                { "After", 1},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.HolderV1 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty1", 11);
            offset += formatterResolver.GetFormatterWithVerify<global::SharedData.Version1>().Serialize(ref bytes, offset, value.MyProperty1, formatterResolver);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "After", 5);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.After);
            return offset - startOffset;
        }

        public global::SharedData.HolderV1 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty1__ = default(global::SharedData.Version1);
            var __After__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty1__ = formatterResolver.GetFormatterWithVerify<global::SharedData.Version1>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 1:
                        __After__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.HolderV1();
            ____result.MyProperty1 = __MyProperty1__;
            ____result.After = __After__;
            return ____result;
        }
    }


    public sealed class HolderV2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.HolderV2>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public HolderV2Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(2)
            {
                { "MyProperty1", 0},
                { "After", 1},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.HolderV2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty1", 11);
            offset += formatterResolver.GetFormatterWithVerify<global::SharedData.Version2>().Serialize(ref bytes, offset, value.MyProperty1, formatterResolver);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "After", 5);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.After);
            return offset - startOffset;
        }

        public global::SharedData.HolderV2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty1__ = default(global::SharedData.Version2);
            var __After__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty1__ = formatterResolver.GetFormatterWithVerify<global::SharedData.Version2>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 1:
                        __After__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.HolderV2();
            ____result.MyProperty1 = __MyProperty1__;
            ____result.After = __After__;
            return ____result;
        }
    }


    public sealed class HolderV0Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.HolderV0>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public HolderV0Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(2)
            {
                { "MyProperty1", 0},
                { "After", 1},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.HolderV0 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty1", 11);
            offset += formatterResolver.GetFormatterWithVerify<global::SharedData.Version0>().Serialize(ref bytes, offset, value.MyProperty1, formatterResolver);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "After", 5);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.After);
            return offset - startOffset;
        }

        public global::SharedData.HolderV0 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty1__ = default(global::SharedData.Version0);
            var __After__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty1__ = formatterResolver.GetFormatterWithVerify<global::SharedData.Version0>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 1:
                        __After__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.HolderV0();
            ____result.MyProperty1 = __MyProperty1__;
            ____result.After = __After__;
            return ____result;
        }
    }


    public sealed class Callback1Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Callback1>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Callback1Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "X", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Callback1 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            value.OnBeforeSerialize();
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "X", 1);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.X);
            return offset - startOffset;
        }

        public global::SharedData.Callback1 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __X__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __X__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Callback1(__X__);
            ____result.X = __X__;
			____result.OnAfterDeserialize();
            return ____result;
        }
    }


    public sealed class Callback1_2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Callback1_2>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Callback1_2Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "X", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Callback1_2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            ((IMessagePackSerializationCallbackReceiver)value).OnBeforeSerialize();
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "X", 1);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.X);
            return offset - startOffset;
        }

        public global::SharedData.Callback1_2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __X__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __X__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Callback1_2(__X__);
            ____result.X = __X__;
            ((IMessagePackSerializationCallbackReceiver)____result).OnAfterDeserialize();
            return ____result;
        }
    }


    public sealed class Callback2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Callback2>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Callback2Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "X", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Callback2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            
            value.OnBeforeSerialize();
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "X", 1);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.X);
            return offset - startOffset;
        }

        public global::SharedData.Callback2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __X__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __X__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Callback2(__X__);
            ____result.X = __X__;
			____result.OnAfterDeserialize();
            return ____result;
        }
    }


    public sealed class Callback2_2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Callback2_2>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Callback2_2Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "X", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Callback2_2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            
            ((IMessagePackSerializationCallbackReceiver)value).OnBeforeSerialize();
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "X", 1);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.X);
            return offset - startOffset;
        }

        public global::SharedData.Callback2_2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __X__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __X__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Callback2_2(__X__);
            ____result.X = __X__;
            ((IMessagePackSerializationCallbackReceiver)____result).OnAfterDeserialize();
            return ____result;
        }
    }


    public sealed class MySubUnion1Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.MySubUnion1>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public MySubUnion1Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "One", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.MySubUnion1 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "One", 3);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.One);
            return offset - startOffset;
        }

        public global::SharedData.MySubUnion1 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __One__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __One__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.MySubUnion1();
            ____result.One = __One__;
            return ____result;
        }
    }


    public sealed class MySubUnion2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.MySubUnion2>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public MySubUnion2Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "Two", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.MySubUnion2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Two", 3);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Two);
            return offset - startOffset;
        }

        public global::SharedData.MySubUnion2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __Two__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __Two__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.MySubUnion2();
            ____result.Two = __Two__;
            return ____result;
        }
    }


    public sealed class MySubUnion3Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.MySubUnion3>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public MySubUnion3Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "Three", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.MySubUnion3 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Three", 5);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Three);
            return offset - startOffset;
        }

        public global::SharedData.MySubUnion3 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __Three__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __Three__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.MySubUnion3();
            ____result.Three = __Three__;
            return ____result;
        }
    }


    public sealed class MySubUnion4Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.MySubUnion4>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public MySubUnion4Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "Four", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.MySubUnion4 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "Four", 4);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Four);
            return offset - startOffset;
        }

        public global::SharedData.MySubUnion4 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __Four__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __Four__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.MySubUnion4();
            ____result.Four = __Four__;
            return ____result;
        }
    }


    public sealed class VersioningUnionFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.VersioningUnion>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public VersioningUnionFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "FV", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.VersioningUnion value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "FV", 2);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.FV);
            return offset - startOffset;
        }

        public global::SharedData.VersioningUnion Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __FV__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __FV__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.VersioningUnion();
            ____result.FV = __FV__;
            return ____result;
        }
    }


    public sealed class MyClassFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.MyClass>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public MyClassFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(3)
            {
                { "MyProperty1", 0},
                { "MyProperty2", 1},
                { "MyProperty3", 2},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.MyClass value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 3);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty1", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty2", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty3", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty3);
            return offset - startOffset;
        }

        public global::SharedData.MyClass Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty1__ = default(int);
            var __MyProperty2__ = default(int);
            var __MyProperty3__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty1__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __MyProperty2__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 2:
                        __MyProperty3__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.MyClass();
            ____result.MyProperty1 = __MyProperty1__;
            ____result.MyProperty2 = __MyProperty2__;
            ____result.MyProperty3 = __MyProperty3__;
            return ____result;
        }
    }


    public sealed class VersionBlockTestFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.VersionBlockTest>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public VersionBlockTestFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(3)
            {
                { "MyProperty", 0},
                { "UnknownBlock", 1},
                { "MyProperty2", 2},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.VersionBlockTest value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 3);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty", 10);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "UnknownBlock", 12);
            offset += formatterResolver.GetFormatterWithVerify<global::SharedData.MyClass>().Serialize(ref bytes, offset, value.UnknownBlock, formatterResolver);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty2", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty2);
            return offset - startOffset;
        }

        public global::SharedData.VersionBlockTest Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty__ = default(int);
            var __UnknownBlock__ = default(global::SharedData.MyClass);
            var __MyProperty2__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __UnknownBlock__ = formatterResolver.GetFormatterWithVerify<global::SharedData.MyClass>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 2:
                        __MyProperty2__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.VersionBlockTest();
            ____result.MyProperty = __MyProperty__;
            ____result.UnknownBlock = __UnknownBlock__;
            ____result.MyProperty2 = __MyProperty2__;
            return ____result;
        }
    }


    public sealed class UnVersionBlockTestFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.UnVersionBlockTest>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public UnVersionBlockTestFormatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(2)
            {
                { "MyProperty", 0},
                { "MyProperty2", 1},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.UnVersionBlockTest value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 2);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty", 10);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty2", 11);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty2);
            return offset - startOffset;
        }

        public global::SharedData.UnVersionBlockTest Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty__ = default(int);
            var __MyProperty2__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __MyProperty2__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.UnVersionBlockTest();
            ____result.MyProperty = __MyProperty__;
            ____result.MyProperty2 = __MyProperty2__;
            return ____result;
        }
    }


    public sealed class Empty1Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Empty1>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Empty1Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(0)
            {
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Empty1 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 0);
            return offset - startOffset;
        }

        public global::SharedData.Empty1 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;


            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Empty1();
            return ____result;
        }
    }


    public sealed class Empty2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.Empty2>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public Empty2Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(0)
            {
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.Empty2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 0);
            return offset - startOffset;
        }

        public global::SharedData.Empty2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;


            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.Empty2();
            return ____result;
        }
    }


    public sealed class NonEmpty1Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.NonEmpty1>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public NonEmpty1Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "MyProperty", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.NonEmpty1 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty", 10);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty);
            return offset - startOffset;
        }

        public global::SharedData.NonEmpty1 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.NonEmpty1();
            ____result.MyProperty = __MyProperty__;
            return ____result;
        }
    }


    public sealed class NonEmpty2Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::SharedData.NonEmpty2>
    {

        readonly global::System.Collections.Generic.Dictionary<string, int> ____keyMapping;

        public NonEmpty2Formatter()
        {
            this.____keyMapping = new global::System.Collections.Generic.Dictionary<string, int>(1)
            {
                { "MyProperty", 0},
            };
        }


        public int Serialize(ref byte[] bytes, int offset, global::SharedData.NonEmpty2 value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedMapHeaderUnsafe(ref bytes, offset, 1);
            offset += global::MessagePack.MessagePackBinary.WriteStringUnsafe(ref bytes, offset, "MyProperty", 10);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.MyProperty);
            return offset - startOffset;
        }

        public global::SharedData.NonEmpty2 Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadMapHeader(bytes, offset, out readSize);
            offset += readSize;

            var __MyProperty__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.MessagePackBinary.ReadString(bytes, offset, out readSize);
                offset += readSize;
                int key;
                if (____keyMapping.TryGetValue(stringKey, out key))
                {
                    readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __MyProperty__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                
                NEXT_LOOP:
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::SharedData.NonEmpty2();
            ____result.MyProperty = __MyProperty__;
            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
