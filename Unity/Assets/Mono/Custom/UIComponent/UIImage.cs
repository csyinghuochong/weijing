using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using KO;

public class UIImage : Image
{
    public UIAtlasInfo AtlasInfo
    {
        get { return mAtlasInfo; }
        set
        {
            if (mAtlasInfo != value)
            {
                mAtlasInfo = value;
                if (mAtlasInfo != null && !string.IsNullOrEmpty(mSpriteName))
                    sprite = mAtlasInfo.GetSpriteByName(mSpriteName);
                SetVerticesDirty();
            }
        }
    }

    public string SpriteName
    {
        get { return mSpriteName; }
        set
        {
            mSpriteName = value;
            if (mAtlasInfo != null)
            {
                sprite = mAtlasInfo.GetSpriteByName(mSpriteName);
                if (this)
                    SetVerticesDirty();
            }
        }
    }

    public bool Maskable
    {
        get { return mMaskable; }
        set
        {
            mMaskable = value;
            maskable = value;
        }
    }

    public bool isCustomMaterial
    {
        get { return m_Material != null; }
    }

    [SerializeField] private UIAtlasInfo mAtlasInfo;
    [SerializeField] private string mSpriteName;
    [SerializeField] private bool mMaskable;

    public new bool maskable
    {
        get { return this.mMaskable; }
        set
        {
            if (value == this.mMaskable)
                return;
            this.mMaskable = value;
            this.m_ShouldRecalculateStencil = true;
            this.SetMaterialDirty();
        }
    }

    [SerializeField] private bool mRaycastTarget = false;
    public override bool raycastTarget { get => mRaycastTarget; 
        set
        {
            if (value == this.mRaycastTarget)
                return;
            this.mRaycastTarget = value;
            base.raycastTarget = value;
        } 
    }

    protected override void Awake()
    {
        base.Awake();
        if (!mMaskable)
        {
            maskable = false;
            m_StencilValue = 0;
        }
        if (!mRaycastTarget)
            raycastTarget = false;
    }

    public override Material GetModifiedMaterial(Material baseMaterial)
    {
        Material baseMat = baseMaterial;
        if (mMaskable == false)
            return baseMat;
        if (this.m_ShouldRecalculateStencil)
        {
            this.m_StencilValue = !mMaskable
                ? 0
                : MaskUtilities.GetStencilDepth(this.transform,
                    MaskUtilities.FindRootSortOverrideCanvas(this.transform));
            this.m_ShouldRecalculateStencil = false;
        }

        Mask component = this.GetComponent<Mask>();
        if (this.m_StencilValue > 0 && (component == null || !component.IsActive()))
        {
            Material material = StencilMaterial.Add(baseMat, (1 << this.m_StencilValue) - 1, StencilOp.Keep,
                CompareFunction.Equal, ColorWriteMask.All, (1 << this.m_StencilValue) - 1, 0);
            StencilMaterial.Remove(this.m_MaskMaterial);
            this.m_MaskMaterial = material;
            baseMat = this.m_MaskMaterial;
        }

        return baseMat;
    }

    public virtual void SetGray(bool gray)
    {
        this.material = null; //gray ? AtlasUtils.GrayMaterial : null;
    }

    public void Clear()
    {
        mAtlasInfo = null;
        mSpriteName = null;
        sprite = null;
    }
}