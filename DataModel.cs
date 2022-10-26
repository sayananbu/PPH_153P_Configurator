﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PPH_153P_Configurator
{
    public enum SettingType
    {
        TopAZ,
        TopPS,
        BottomPS,
        BottomAZ
    }
    [Serializable]
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
    [Serializable]
    public class DataModel: ObservableObject
    {
        private byte _nodeId;
        public byte NodeId
        {
            get { return _nodeId; }
            set { _nodeId = value;
                OnPropertyChanged("NodeId");
            }
        }
        private int[] _stateBitArray;

        public int[] StateBitArray
        {
            get { return _stateBitArray; }
            set { _stateBitArray = value;
                OnPropertyChanged("StateBitArray");
            }
        }

        private int[] _analogStateBitArray;

        public int[] AnalogStateBitArray
        {
            get { return _analogStateBitArray; }
            set
            {
                _analogStateBitArray = value;
                OnPropertyChanged("AnalogStateBitArray");
            }
        }


        private float _minSignalRange;
        public float MinSignalRange
        {
            get { return _minSignalRange; }
            set {_minSignalRange = value;
                OnPropertyChanged("MinSignalRange");
            }
        }


        private float _maxSignalRange;
        public float MaxSignalRange
        {
            get { return _maxSignalRange; }
            set { _maxSignalRange = value;
                OnPropertyChanged("MaxSignalRange");
            }
        }


        private Int16 _averaging;

        public Int16 Averaging
        {
            get { return _averaging; }
            set { _averaging = value;
                OnPropertyChanged("Averaging");
            }
        }


        private byte _deviceStatus;
        public byte DeviceStatus
        {
            get { return _deviceStatus; }
            set { 
                _deviceStatus = value;
                OnPropertyChanged("DeviceStatus");
            }
        }

        private int _inputSignalCode;
        public int InputSignalCode
        {
            get { return _inputSignalCode; }
            set { 
                _inputSignalCode = value;
                OnPropertyChanged("InputSignalCode");
            }
        }


        private float _value;
        public float Value { get { return _value; } 
            set {
                _value = value;
                OnPropertyChanged("Value");
                } }

        public Setting TopAZ { get; set; }
        public Setting TopPS { get;  set; }
        public Setting BottomPS { get;  set; }
        public Setting BottomAZ { get;  set; }
        public DataModel()
        {
            TopAZ = new Setting(SettingType.TopAZ);
            TopPS = new Setting(SettingType.TopPS);
            BottomPS = new Setting(SettingType.BottomPS);
            BottomAZ = new Setting(SettingType.BottomAZ);
        }
        
        
    }
    [Serializable]
    public class Setting:ObservableObject
    {
        public Setting(SettingType type)
        {
            Type = type;
            Histeresis = 0;
            IsSet = true;
            SettingSetter = false;
        }
        

        private SettingType _type;
        public SettingType Type { 
            get { return _type; } 
            set { _type = value;
                OnPropertyChanged("Type");
            } 
        }
        private float _value;
        public float Value { 
            get { return _value; }
            set { _value= value;
                OnPropertyChanged("Value");
            }    
        }
        private int _histeresis;
        public int Histeresis { 
            get { return _histeresis; }
            set { _histeresis = value;
                OnPropertyChanged("Histeresis");
            } 
        }
        public byte isSetValue;
        private bool _isSet;
        public bool IsSet
        {
            get { return _isSet; }
            set { _isSet = value;
                if (value)
                {
                    switch (_type)
                    {
                        case SettingType.TopAZ:case SettingType.TopPS:
                            isSetValue = 2;
                            break;
                        case SettingType.BottomAZ:case SettingType.BottomPS:
                            isSetValue = 3;
                            break;
                    }
                }else isSetValue = 0;
                OnPropertyChanged("IsSet");
            }
        }
        private bool _settingSetter;

        public bool SettingSetter
        {
            get { return _settingSetter; }
            set { _settingSetter = value;
                OnPropertyChanged("SettingSetter");
            }
        }

    }
}
